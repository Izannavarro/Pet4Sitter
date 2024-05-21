using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using piTest;
using piTest.Clases;

public class GoogleAuthenticator
{
    // Configuración del cliente
    public readonly string clientID;
    private readonly string clientSecret;
    private static  readonly string authorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
    private static  readonly string tokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";
    //private static  readonly string userInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";

    public GoogleAuthenticator(string clientId, string clientSecret)
    {
        this.clientID = clientId;
        this.clientSecret = clientSecret;
    }

    public string AuthorizationEndpoint { get { return authorizationEndpoint; } }
    public string ClientID { get { return this.clientID; } }

    public async Task<string> StartAuthentication()
    {
        // Generar valores de state y PKCE
        string state = randomDataBase64url(32);
        string code_verifier = randomDataBase64url(32);
        string code_challenge = base64urlencodeNoPadding(sha256(code_verifier));
        const string code_challenge_method = "S256";

        // Crear un URI de redirección utilizando un puerto disponible en localhost
        string redirectURI = string.Format("http://{0}:{1}/", IPAddress.Loopback, GetRandomUnusedPort());

        // Crear la solicitud de autorización OAuth 2.0
        string authorizationRequest = string.Format("{0}?response_type=code&scope=openid%20profile&redirect_uri={1}&client_id={2}&state={3}&code_challenge={4}&code_challenge_method={5}",
            authorizationEndpoint,
            System.Uri.EscapeDataString(redirectURI),
            clientID,
            state,
            code_challenge,
            code_challenge_method);

        // Iniciar el servidor HTTP para escuchar la respuesta
        var responseListener = new HttpListener();
        responseListener.Prefixes.Add(redirectURI);
        responseListener.Start();

        // Abrir la solicitud de autorización en el navegador predeterminado
        Process.Start(authorizationRequest);

        // Esperar la respuesta de autorización OAuth
        var context = await responseListener.GetContextAsync();

        // Capturar la respuesta
        var code = context.Request.QueryString.Get("code");
        var incoming_state = context.Request.QueryString.Get("state");

        // Comparar el estado recibido con el valor esperado
        if (incoming_state != state)
        {
            throw new InvalidOperationException($"Se recibió una solicitud con un estado no válido ({incoming_state})");

        }

        // Cerrar el servidor HTTP
        responseListener.Stop();

        // Cerrar la ventana del navegador
        CloseBrowserWindow();

        // Intercambiar el código por tokens
        var tokenResponse = await PerformCodeExchange(code, code_verifier, redirectURI);
        return tokenResponse;
    }

    private void CloseBrowserWindow()
    {
        // Obtener el proceso del navegador
        Process[] processes = Process.GetProcessesByName("chrome");
        foreach (Process process in processes)
        {
            // Verificar si el proceso pertenece al usuario actual y tiene una ventana principal
            if (process.MainWindowHandle != IntPtr.Zero && process.MainWindowTitle.Contains("Google"))
            {
                // Cerrar la ventana del navegador
                process.CloseMainWindow();
                break; // Salir del bucle una vez que se haya cerrado la ventana
            }
        }
    }

    public async Task<string> PerformCodeExchange(string code, string code_verifier, string redirectURI)
    {
        // Construir la solicitud de token
        string tokenRequestBody = string.Format("code={0}&redirect_uri={1}&client_id={2}&code_verifier={3}&client_secret={4}&scope=&grant_type=authorization_code",
            code,
            System.Uri.EscapeDataString(redirectURI),
            clientID,
            code_verifier,
            clientSecret
            );

        // Enviar la solicitud
        HttpWebRequest tokenRequest = (HttpWebRequest)WebRequest.Create(tokenEndpoint);
        tokenRequest.Method = "POST";
        tokenRequest.ContentType = "application/x-www-form-urlencoded";
        byte[] _byteVersion = Encoding.ASCII.GetBytes(tokenRequestBody);
        tokenRequest.ContentLength = _byteVersion.Length;
        Stream stream = tokenRequest.GetRequestStream();
        await stream.WriteAsync(_byteVersion, 0, _byteVersion.Length);
        stream.Close();

        try
        {
            // Obtener la respuesta
            WebResponse tokenResponse = await tokenRequest.GetResponseAsync();
            using (StreamReader reader = new StreamReader(tokenResponse.GetResponseStream()))
            {
                // Leer el cuerpo de la respuesta
                string responseText = await reader.ReadToEndAsync();
                output(responseText);

                // Convertir a diccionario
                Dictionary<string, string> tokenEndpointDecoded = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);

                string access_token = tokenEndpointDecoded["access_token"];
                return access_token;
            }
        }
        catch (WebException ex)
        {
            if (ex.Status == WebExceptionStatus.ProtocolError)
            {
                var response = ex.Response as HttpWebResponse;
                if (response != null)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        // Leer el cuerpo de la respuesta
                        string responseText = await reader.ReadToEndAsync();
                        throw new InvalidOperationException($"Error HTTP: {response.StatusCode}, {responseText}");
                    }
                }
            }
            throw;
        }
    }


    public async Task userinfoCall(string access_token)
    {
        try
        {
            output("Realizando llamada a la API de UserInfo...");

            // Depuración: Imprimir el token de acceso
            Console.WriteLine("Token de acceso: " + access_token);

            // Construir la solicitud
            string userinfoRequestURI = "https://www.googleapis.com/oauth2/v3/userinfo";

            // Enviar la solicitud
            HttpWebRequest userinfoRequest = (HttpWebRequest)WebRequest.Create(userinfoRequestURI);
            userinfoRequest.Method = "GET";
            userinfoRequest.Headers.Add(string.Format("Authorization: Bearer {0}", access_token));
            userinfoRequest.ContentType = "application/x-www-form-urlencoded";
            userinfoRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

            // Obtener la respuesta
            WebResponse userinfoResponse = await userinfoRequest.GetResponseAsync();
            using (StreamReader userinfoResponseReader = new StreamReader(userinfoResponse.GetResponseStream()))
            {
                // Leer el cuerpo de la respuesta
                string userinfoResponseText = await userinfoResponseReader.ReadToEndAsync();
                output(userinfoResponseText);

                // Mostrar la información del usuario en el formulario
                //ShowUserInfo(userinfoResponseText);
                Data.Ginfo = userinfoResponseText;
            }
        }
        catch (Exception ex)
        {
            // Manejar la excepción
            Console.WriteLine("Excepción en userinfoCall: " + ex.Message);
            // También podrías lanzar o registrar la excepción, dependiendo de tus necesidades
        }
    }

    public void ShowUserInfo(string userInfo)
    {

        ShowUserInfoOnDashboard(userInfo);
    }

    public void ShowUserInfoOnDashboard(string userInfo)
    {
        Dashboard dashboardForm = new Dashboard(userInfo);
        dashboardForm.Show();
    }

    public void output(string output)
    {
        Console.WriteLine(output);
    }

    // Otros métodos y utilidades permanecen aquí...
    public static int GetRandomUnusedPort()
    {
        var listener = new TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        var port = ((IPEndPoint)listener.LocalEndpoint).Port;
        listener.Stop();
        return port;
    }

    // Retorna datos URI-seguros con una longitud dada
    public static string randomDataBase64url(uint length)
    {
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        byte[] bytes = new byte[length];
        rng.GetBytes(bytes);
        return base64urlencodeNoPadding(bytes);
    }

    // Retorna el hash SHA256 de la cadena de entrada
    public static byte[] sha256(string inputStirng)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(inputStirng);
        SHA256Managed sha256 = new SHA256Managed();
        return sha256.ComputeHash(bytes);
    }

    // Codifica base64url sin relleno el buffer de entrada
    public static string base64urlencodeNoPadding(byte[] buffer)
    {
        string base64 = Convert.ToBase64String(buffer);

        // Convertir base64 a base64url
        base64 = base64.Replace("+", "-");
        base64 = base64.Replace("/", "_");
        // Eliminar relleno
        base64 = base64.Replace("=", "");

        return base64;
    }
    // Recursos de utilidad para la autenticación de Google permanecen aquí...

    public async static Task exchangeCode()
    {
        HttpListener httpListener = new HttpListener();
        //Ocultación de tokens:
        string jsonContent = System.IO.File.ReadAllText("token.JSON");

        // Parsear el contenido JSON
        JObject tokenData = JObject.Parse(jsonContent);

        // Extraer las propiedades del objeto JSON
        string clientId = (string)tokenData["ClientId"];
        string clientSecret = (string)tokenData["ClientSecret"];

        // Generar valores de state y PKCE
        string state = GoogleAuthenticator.randomDataBase64url(32);
        string code_verifier = GoogleAuthenticator.randomDataBase64url(32);
        string code_challenge = GoogleAuthenticator.base64urlencodeNoPadding(GoogleAuthenticator.sha256(code_verifier));
        const string code_challenge_method = "S256";

        int selectedPort = PortManager.FindAvailablePort(9001, 9014);

        if (selectedPort != -1)
        {

            // Crear un URI de redirección utilizando un puerto disponible en localhost
            string redirectURI = string.Format("http://{0}:{1}/", IPAddress.Loopback, selectedPort);
            //output("URI de redirección: " + redirectURI);

            // Iniciar HttpListener para escuchar las solicitudes entrantes en ese URI de redirección
            httpListener = new HttpListener();
            httpListener.Prefixes.Add(redirectURI);
            //output("Escuchando...");
            httpListener.Start();

            // Crear la solicitud de autorización OAuth 2.0
            string authorizationRequest = string.Format("{0}?response_type=code&scope=openid%20profile&redirect_uri={1}&client_id={2}&state={3}&code_challenge={4}&code_challenge_method={5}",
                GoogleAuthenticator.authorizationEndpoint,
                System.Uri.EscapeDataString(redirectURI),
                clientId,
                state,
                code_challenge,
                code_challenge_method);

            // Abrir la solicitud de autorización en el navegador predeterminado del usuario
            Process.Start(authorizationRequest);

            // Esperar la respuesta de autorización OAuth
            var context = await httpListener.GetContextAsync();


            // Sends an HTTP response to the browser.
            var response = context.Response;
            //string filePath = "./gAuthRedirection.html";
            string responseString;

            // Checks for errors.
            if (context.Request.QueryString.Get("error") != null)
            {
                Console.WriteLine(String.Format("OAuth authorization error: {0}.", context.Request.QueryString.Get("error")));
                return;
            }
            if (context.Request.QueryString.Get("code") == null
                || context.Request.QueryString.Get("state") == null)
            {
                Console.WriteLine("Malformed authorization response. " + context.Request.QueryString);
                return;
            }

            // Capturar la respuesta
            // Extraer el código de autorización de la URL de redirección
            var code = context.Request.QueryString.Get("code");
            var incoming_state = context.Request.QueryString.Get("state");

            // Comparar el estado recibido con el valor esperado
            if (incoming_state != state)
            {
                Console.WriteLine(String.Format("Se recibió una solicitud con un estado no válido ({0})", incoming_state));
                return;
            }
            Console.WriteLine("Código de autorización: " + code);



            // Iniciar el intercambio de código en el punto final de token
            // Intercambio de código
            GoogleAuthenticator authenticator = new GoogleAuthenticator(clientId, clientSecret);

            // Resto del código...

            // Intercambio de código
            var accessToken = await authenticator.PerformCodeExchange(code, code_verifier, redirectURI);

            // Obtener información del usuario

            try
            {
                await authenticator.userinfoCall(accessToken);
            }
            catch (TargetInvocationException ex)
            {
                // Acceder a la excepción interna
                Exception innerException = ex.InnerException;
                if (innerException != null)
                {
                    // Manejar la excepción interna
                    Console.WriteLine("Excepción interna: " + innerException.Message);
                }
                else
                {
                    // Si no hay excepción interna, imprimir el mensaje de la excepción original
                    Console.WriteLine("Excepción: " + ex.Message);
                }
            }

            // Parsear la cadena JSON
            JObject userInfoObject = JObject.Parse(Data.Ginfo);
            Console.WriteLine(userInfoObject);

            string googleId = (string)userInfoObject["sub"];
            string name = (string)userInfoObject["name"];

            Data.UserGoogle = new User(null, googleId,name,null,null,null,null,null,null,null,null,null);

            responseString = string.Format($"<html><head><meta http-equiv='refresh' content='0;url=https://oauth-redirect-phi.vercel.app/?gn={name}'></head><body>Redirecting...</body></html>");
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            var responseOutput = response.OutputStream;
            Task responseTask = responseOutput.WriteAsync(buffer, 0, buffer.Length).ContinueWith((task) =>
            {
                responseOutput.Close();
                httpListener.Stop();
                Console.WriteLine("HTTP server stopped.");
            });
            // Cerrar la ventana del navegador
            context.Response.Close();

            //Fin del if del puerto
        }
        else if (selectedPort == -1)
        {
            Console.WriteLine("No hay puertos disponibles");
        }
    }


    }


