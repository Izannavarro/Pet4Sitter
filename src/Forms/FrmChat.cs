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
        int? idChatSeleccionado = null;
        public FrmChat()
        {
            InitializeComponent();
        }

        private async void FrmChat_Load(object sender, EventArgs e)
        {
            CargarUltimosChats();
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
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
                    // Reemplaza los valores en la consulta con parámetros
                    string query = @"SELECT * FROM chat 
                             WHERE (id_receiver = @CurrentUserId OR id_sender = @CurrentUserId)
                             AND (id_receiver = @SelectedChatId OR id_sender = @SelectedChatId)
                             ORDER BY date";

                    // Crear un comando utilizando parámetros
                    using (MySqlCommand cmd = new MySqlCommand(query, ConBD.Conexion))
                    {
                        // Agregar los parámetros con valores
                        cmd.Parameters.AddWithValue("@CurrentUserId", Data.CurrentUser.IdUser);
                        cmd.Parameters.AddWithValue("@SelectedChatId", idChatSeleccionado);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
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
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                CargarUltimosChats();
                if (idChatSeleccionado != null)
                {
                    await ChatMensajes();
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
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

        private void pnl1_MouseHover(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.Orange;
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarUltimosChats()
        {
            try
            {
                // Consulta para obtener los chats más recientes por usuario
                string query = @"
            SELECT u.id_user, u.name, c.date
            FROM (
                SELECT 
                    IF(id_sender = @CurrentUserId, id_receiver, id_sender) AS chat_partner,
                    MAX(date) AS max_date
                FROM chat
                WHERE id_receiver = @CurrentUserId OR id_sender = @CurrentUserId
                GROUP BY chat_partner
            ) AS latest_chats
            INNER JOIN chat c ON c.date = latest_chats.max_date AND 
                (c.id_sender = latest_chats.chat_partner OR c.id_receiver = latest_chats.chat_partner)
            INNER JOIN users u ON u.id_user = latest_chats.chat_partner
            ORDER BY c.date DESC";

                // Ejecutar la consulta
                DataTable d = Utiles.ExecuteQuery(query, new MySqlParameter("@CurrentUserId", Data.CurrentUser.IdUser));

                // Limpiar los labels antes de asignar nuevos valores
                lblIdChat1.Text = "";
                lblNombre1.Text = "";
                lblIdChat2.Text = "";
                lblNombre2.Text = "";
                lblIdChat3.Text = "";
                lblNombre3.Text = "";
                lblIdChat4.Text = "";
                lblNombre4.Text = "";

                // Verificar y asignar los valores a los labels
                if (d.Rows.Count > 0)
                {
                    lblIdChat1.Text = d.Rows[0]["id_user"].ToString();
                    lblNombre1.Text = d.Rows[0]["name"].ToString();
                }

                if (d.Rows.Count > 1)
                {
                    lblIdChat2.Text = d.Rows[1]["id_user"].ToString();
                    lblNombre2.Text = d.Rows[1]["name"].ToString();
                }

                if (d.Rows.Count > 2)
                {
                    lblIdChat3.Text = d.Rows[2]["id_user"].ToString();
                    lblNombre3.Text = d.Rows[2]["name"].ToString();
                }

                if (d.Rows.Count > 3)
                {
                    lblIdChat4.Text = d.Rows[3]["id_user"].ToString();
                    lblNombre4.Text = d.Rows[3]["name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los chats: {ex.Message}");
            }
        }


        private async void pnl1_Click(object sender, EventArgs e)
        {
            fLPanelChat.Controls.Clear();
            idChatSeleccionado = int.Parse(lblIdChat1.Text.ToString());
            await ChatMensajes();
        }

        private void pnl1_MouseLeave(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.White;
        }

        private async void pnl2_Click(object sender, EventArgs e)
        {
            fLPanelChat.Controls.Clear();
            idChatSeleccionado = int.Parse(lblIdChat2.Text.ToString());
            await ChatMensajes();
        }
    }
}
