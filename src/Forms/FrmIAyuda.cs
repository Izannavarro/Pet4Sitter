using OpenAI_API;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using pet4sitter.Clases;

namespace pet4sitter
{
    public partial class FrmIAyuda : Form
    {
        private List<Prompt> promptList = new List<Prompt>();
        private int currentIndex = -1;

        public FrmIAyuda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await VerificarConexionYActualizarUI();
        }

        private async Task VerificarConexionYActualizarUI()
        {
            while (true)
            {
                if (!VerificarConexionInternet())
                {
                    ActualizarUIConection(false);
                }
                else
                {
                    ActualizarUIConection(true);

                    break; // Salir del bucle si hay conexión a Internet
                }

                // Esperar un breve período antes de volver a verificar la conexión
                await Task.Delay(1000); // Esperar 1 segundo (ajusta este valor según lo deseado)
            }
        }
        private void ActualizarUIConection(bool b)
        {
            if (!b)
            {

                pcbNoWifi.Visible = true;
                btnSend.Enabled = false;
                lblAnswer.Visible = false;
                lblQuestion.Visible = false;
                lblYou.Visible = false;
                lblIA.Visible = false;
                pcbAI.Visible = false;
                pcbUser.Visible = false;
                txtPrompt.Enabled = false;
                lblErrorWifi.Visible = true;
            }
            else
            {
                pcbNoWifi.Visible = false;
                btnSend.Enabled = true;
                lblAnswer.Visible = true;
                lblQuestion.Visible = true;
                lblYou.Visible = true;
                lblIA.Visible = true;
                pcbAI.Visible = true;
                pcbUser.Visible = true;
                txtPrompt.Enabled = true;
                lblErrorWifi.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linklabFAQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.zendesk.com.mx/blog/que-es-faq/");
        }

        private async void btnSend_ClickAsync(object sender, EventArgs e)
        {
            pcbLoading.Visible = true;
            if (txtPrompt.Text != "")
            {
                await mandarPrompt();
            }
            pcbLoading.Visible = false;
        }

        private void anyadirElementoListaCmBox()
        {
            if(promptList.Count > 8 )
            {
                promptList.RemoveAt(0);
                cmbPrompts.Items.RemoveAt(0);
            }
            else
            {
                currentIndex++;
            }
            cmbPrompts.Items.Add(promptList[currentIndex].Input);
            cmbPrompts.SelectedIndex = currentIndex;
        }

        private async Task mandarPrompt()
        {
            try
            {
                // Create an instance of the APIAuthentication class with your API key
                var authentication = new APIAuthentication("");

                // Create an instance of the OpenAIAPI class with the APIAuthentication object
                var api = new OpenAIAPI(authentication);
                // Create a new conversation with ChatGPT
                var conversation = api.Chat.CreateConversation();

                // Append user input and get response from ChatGPT
                string prompt = "Imagina que eres un chatbot de ayuda para una Aplicación de escritorio de Windows, a continuación te voy a dar información de la aplicación y al final de este prompt estará el prompt introducido por el usuario. Quiero que tu respuesta sea breve y cordial, solamente como si te dirigieses al usuario, te digo informacion de la app:\r\nPet4Sitter es una app para gente que necesita a alguien para que cuide a su mascota, Esta aplicación tiene varios apartados, entre ellos el home que tiene un pequeño chat con los chats más recientes, dos productos top de la tienda, y un pequeño recuadro con noticias , este recuadro solo estará desbloqueado para los usuarios PREMIUM en caso de no ser premium simplemente aparecerá un candado.\r\nDespués tenemos el apartado de búsqueda el cuál no tiene mucho misterio, simplemente para buscar cuidador, Los resultados de la busqueda se podrán filtrar y ordenar y en una búsqueda saldrá foto del cuidador, descripcion y puntuación, para contactar al cuidador hay que pulsar en él.\r\nDespués tenemos un pequeño chat en tiempo real que tampoco tiene mucho más allá de eso.También hay un apartado específicamente para noticias, el cuál se encarga de recopilar noticias relevantes sobre animales, si alguien te pregunta porque no se ve debes decir que es funcionalidad premium.\r\nTenemos la tienda con productos, y la IAyuda que es lo que están usando ahora, es un pequeño chat con ayuda mediante IA.\r\nTenemos también el apartado de ajustes el cuál sirve para cambiar el idioma, el tema de la aplicación, activar la verificación en 2 pasos y desactivar o eliminar la cuenta.\r\nPor último tenemos el apartado de perfil, en el cuál podremos darnos de alta o baja como cuidadores cambiar nuestro estado, disponible o ocupado y editar el perfil, cambiar mail contraseña etc...\r\nRecuerda que tu respuesta es para un usuario final, por lo tanto debes ser claro y conciso.Quiero que solamente contestes a preguntas realcionadas con la App o con animales si no son muy difíciles, si las preguntas con animales tienen que ver como algo bastante importante como podría ser la salud quiero que recalques que eres una IA y que puedes tener errores, si no tienen que ver con la app recalca que eso no tiene que ver con la app, a continuación te paso la pregunta del usuario:\r\n"
                    + txtPrompt.Text;
                conversation.AppendUserInput(prompt);
                var response = await conversation.GetResponseFromChatbotAsync();
                Console.WriteLine(response);
                lblQuestion.Text = txtPrompt.Text;
                lblAnswer.Text = response;
                promptList.Add(new Prompt(txtPrompt.Text, lblAnswer.Text));
                txtPrompt.Text = "";
                anyadirElementoListaCmBox();
            }
            catch (Exception)
            {
                // Manejar la excepción, puedes mostrar un mensaje de error o realizar otra acción
                ActualizarUIConection(false);
            }
        }
        public bool VerificarConexionInternet()
        {
            try
            {   
                using (var client = new WebClient())
                using (var stream = client.OpenRead("ahttp://www.google.com"))
                {
                    return true; // Se obtuvo una respuesta exitosa
                }
            }
            catch
            {
                return false; // No se pudo obtener una respuesta
            }
        }

        private void cmbPrompts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = cmbPrompts.SelectedIndex;
            lblQuestion.Text = promptList[indiceSeleccionado].Input;
            lblAnswer.Text = promptList[indiceSeleccionado].Output;
            ActualizarUIConection(true);
        }

        private void lblErrorWifi_Click(object sender, EventArgs e)
        {

        }

        private void barraLateral1_Load(object sender, EventArgs e)
        {

        }
    }
}
