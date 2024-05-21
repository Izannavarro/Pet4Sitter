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

        private async void FrmChat_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            await ChatMensajes();
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

        private List<string> mensajesCargados = new List<string>();

        private async Task ChatMensajes()
        {
            if (ConBD.Conexion != null)
            {
                try
                {
                    string query = $"SELECT * FROM chat WHERE (id_receiver={Data.CurrentUser.IdUser} OR id_sender={Data.CurrentUser.IdUser}) AND (id_receiver=2 OR id_sender=2) order by date";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, ConBD.Conexion);
                    DataTable mensajes = new DataTable();
                    await Task.Run(() => adapter.Fill(mensajes)); // Asíncrono

                    if (mensajes != null)
                    {
                        SuspendLayout(); // Suspender el diseño del formulario
                        fLPanelChat.SuspendLayout(); // Suspender el diseño del panel

                        bool nuevosMensajes = false; // Bandera para saber si se agregaron nuevos mensajes

                        foreach (DataRow row in mensajes.Rows)
                        {
                            string mensajeId = row["id"].ToString();
                            if (!mensajesCargados.Contains(mensajeId))
                            {
                                mensajesCargados.Add(mensajeId);
                                nuevosMensajes = true;

                                if (row["id_receiver"].ToString() == Data.CurrentUser.IdUser.ToString())
                                {
                                    MensajeEnviado mensajeEnviado = new MensajeEnviado();
                                    mensajeEnviado.Dock = DockStyle.Top;
                                    mensajeEnviado.BringToFront();
                                    mensajeEnviado.Title = row["messages"].ToString();
                                    fLPanelChat.Controls.Add(mensajeEnviado);
                                }
                                else if (row["id_sender"].ToString() == Data.CurrentUser.IdUser.ToString())
                                {
                                    MensajeRecibido mensajeRecibido = new MensajeRecibido();
                                    mensajeRecibido.Dock = DockStyle.Top;
                                    mensajeRecibido.BringToFront();
                                    mensajeRecibido.Title = row["messages"].ToString();
                                    fLPanelChat.Controls.Add(mensajeRecibido);
                                }
                            }
                        }

                        fLPanelChat.ResumeLayout(true); // Reanudar el diseño del panel
                        ResumeLayout(true); // Reanudar el diseño del formulario

                        if (nuevosMensajes)
                        {
                            ScrollToBottom(); // Desplazar al fondo si hay nuevos mensajes
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
        }


        private void ScrollToBottom()
        {
            if (fLPanelChat.Controls.Count > 0)
            {
                var lastControl = fLPanelChat.Controls[fLPanelChat.Controls.Count - 1];
                fLPanelChat.ScrollControlIntoView(lastControl);
            }
        }


        private async void tmr_Tick(object sender, EventArgs e)
        {
            await ChatMensajes();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                Mensaje m = new Mensaje((int)Data.CurrentUser.IdUser, 2, txtMensaje.Text);
                Mensaje.EnviarMensaje(m);
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
        }
    }
}
