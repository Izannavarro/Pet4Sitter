using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piTest.Clases
{
    public class Utiles
    {
        public static string CargarTokenNoticias()
        {
            try
            {
                // Ruta del archivo token.json
                string rutaArchivo = "token.json";

                // Verifica si el archivo existe
                if (File.Exists(rutaArchivo))
                {
                    // Lee el contenido del archivo JSON
                    string contenidoJson = File.ReadAllText(rutaArchivo);

                    // Convierte el contenido a un objeto JSON
                    JObject tokenJson = JObject.Parse(contenidoJson);

                    // Obtén el valor del atributo 'news' y asígnalo a ApiNoticias
                    return tokenJson["News"].ToString();
                }
                else
                {
                    throw new FileNotFoundException("El archivo token.json no fue encontrado.");
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra al cargar el token de noticias
                Console.WriteLine($"Error al cargar el token de noticias: {ex.Message}");
            }
            return "err";
        }
    }
}
