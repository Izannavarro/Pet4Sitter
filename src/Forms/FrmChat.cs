using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pet4sitter.Clases;
using MySql.Data.MySqlClient;
using pet4sitter.Forms;

namespace pet4sitter
{
    public partial class FrmChat : Form
    {
        public FrmChat()
        {
            InitializeComponent();
        }

        private void FrmChat_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            ChatMensajes();
        }

        private void AplicarIdioma()
        {
            lblNombre1.Text = Resources.Recursos_Localizable.FrmChat.lblNombre1_Text;
            lblNombre2.Text = Resources.Recursos_Localizable.FrmChat.lblNombre2_Text;
            lblNombre3.Text = Resources.Recursos_Localizable.FrmChat.lblNombre3_Text;
            lblNombre4.Text = Resources.Recursos_Localizable.FrmChat.lblNombre4_Text;
            lblNombre5.Text = Resources.Recursos_Localizable.FrmChat.lblNombre5_Text;
            btnSiguiente.Text = Resources.Recursos_Localizable.FrmChat.btnSiguiente_Text;
            btnAnterior.Text = Resources.Recursos_Localizable.FrmChat.btnAnterior_Text;
            btnOpciones.Text = Resources.Recursos_Localizable.FrmChat.btnOpciones_Text;
            btnEnviar.Text = Resources.Recursos_Localizable.FrmChat.btnEnviar_Text;
        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show(); // Muestra el formulario FrmConfiguracion
        }

        private void FrmChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ChatMensajes()
        {
            if (ConBD.Conexion != null)
            {
                //ConBD.AbrirConexion();
                string query = "SELECT * FROM chat WHERE id_receiver=1 OR id_sender = 1 AND id_receiver=2 OR id_sender = 2";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, ConBD.Conexion);
                DataTable mensajes = new DataTable();
                adapter.Fill(mensajes);
                if(mensajes != null)
                {
                        foreach (DataRow row in mensajes.Rows)
                        {
                            //Aquí comprobaría si los usuarios son correctos en cuanto al res de la consulta(Próximamente)
                            if (row["id_receiver"].ToString() == "1")
                            {
                            MensajeEnviado mensajeEnviado = new MensajeEnviado();
                            mensajeEnviado.Dock = DockStyle.Top;
                            mensajeEnviado.BringToFront();
                            mensajeEnviado.Title = row["messages"].ToString();
                            fLPanelChat.Controls.Add(mensajeEnviado);
                            fLPanelChat.ScrollControlIntoView(mensajeEnviado); // Asegura que el mensaje esté visible
                        }
                        else if(row["id_sender"].ToString() == "1")
                            {
                            MensajeRecibido mensajeRecibido = new MensajeRecibido();
                            mensajeRecibido.Dock = DockStyle.Top;
                            mensajeRecibido.BringToFront();
                            mensajeRecibido.Title = row["messages"].ToString();
                            fLPanelChat.Controls.Add(mensajeRecibido);
                            fLPanelChat.ScrollControlIntoView(mensajeRecibido); // Asegura que el mensaje esté visible
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }


    }
}
