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
        private int paginaActual = 0;
        private int elementosPorPagina = 4; // Cantidad de chats que se muestran por página
        private int totalChats = 0;

        private string[] currentChatIds = new string[4];

        public FrmChat()
        {
            InitializeComponent();
        }
        public FrmChat(int idChat)
        {
            InitializeComponent();
            idChatSeleccionado = idChat;
        }

        private async void FrmChat_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            ModoOscuro();

            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                totalChats = Mensaje.ContarTotalChats();
                CargarUltimosChats();
                if (idChatSeleccionado != null)
                {
                    User usu = User.EncontrarUsuario((int)idChatSeleccionado);
                    lblNombreChatActivo.Text = usu.Name;
                    pcbImagen5.Image = Properties.Resources.usuario;
                    if (usu.Image != null)
                    {
                        pcbImagen5.Image = Utiles.ByteArrayToImage(usu.Image);
                    }
                    MostrarPanelesChat();
                    await ChatMensajes();
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
            ActualizarPagina();
        }

        private void ModoOscuro()
        {
            if (Data.DarkMode)
            {
                this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
                this.BackColor = Color.DarkGreen;
                pnlChat.BackColor = Color.FromArgb(187, 133, 98);
            }
        }

        private void AplicarIdioma()
        {
            lblNombre1.Text = Resources.Recursos_Localizable.FrmChat.lblNombre1_Text;
            lblNombre2.Text = Resources.Recursos_Localizable.FrmChat.lblNombre2_Text;
            lblNombre3.Text = Resources.Recursos_Localizable.FrmChat.lblNombre3_Text;
            lblNombre4.Text = Resources.Recursos_Localizable.FrmChat.lblNombre4_Text;
            lblNombreChatActivo.Text = Resources.Recursos_Localizable.FrmChat.lblNombre5_Text;
            btnSiguiente.Text = Resources.Recursos_Localizable.FrmChat.btnSiguiente_Text;
            btnAnterior.Text = Resources.Recursos_Localizable.FrmChat.btnAnterior_Text;
            btnCerrarChat.Text = Resources.Recursos_Localizable.FrmChat.btnOpciones_Text;
            btnEnviar.Text = Resources.Recursos_Localizable.FrmChat.btnEnviar_Text;
        }

        private void FrmChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private List<string> mensajesCargados = new List<string>();
        private void MostrarPanelesChat()
        {
            pnlInfoChat.Visible = true;
            pnlChat.Visible = true;
        }
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
                        adapter.Fill(mensajes);

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
                                        mensajeRecibido.Icon = pcbImagen5.Image;
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

        private void ActualizarPagina()
        {
            int totalPaginas = (int)Math.Ceiling((double)totalChats / elementosPorPagina);
            int paginaActualIndex = paginaActual + 1;

            lblPagina.Text = $"Página {paginaActualIndex} de {totalPaginas}";
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
                if (ConBD.Conexion.State != ConnectionState.Open)
                {
                    ConBD.AbrirConexion();
                }
                CargarUltimosChats();
                if (idChatSeleccionado != null)
                {
                    await ChatMensajes();
                }
                if (ConBD.Conexion.State != ConnectionState.Closed)
                {
                    ConBD.CerrarConexion();
                }
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
                Mensaje m = new Mensaje((int)Data.CurrentUser.IdUser, idChatSeleccionado, txtMensaje.Text);
                Mensaje.EnviarMensaje(m);
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
            txtMensaje.Clear();
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
                string query = @"
        SELECT DISTINCT u.id_user, u.name, c.date, u.image
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
        ORDER BY c.date DESC
        LIMIT @Limit OFFSET @Offset";

                // Ejecutar la consulta con parámetros
                DataTable d = Utiles.ExecuteQuery(query,
                    new MySqlParameter("@CurrentUserId", Data.CurrentUser.IdUser),
                    new MySqlParameter("@Offset", paginaActual * elementosPorPagina),
                    new MySqlParameter("@Limit", elementosPorPagina));

                // Crear una lista de controles para actualizar
                var labelsIdChat = new[] { lblIdChat1, lblIdChat2, lblIdChat3, lblIdChat4 };
                var labelsNombre = new[] { lblNombre1, lblNombre2, lblNombre3, lblNombre4 };
                var pictureBoxes = new[] { pcbImagen1, pcbImagen2, pcbImagen3, pcbImagen4 };

                bool anyChange = false;

                for (int i = 0; i < 4; i++)
                {
                    if (i < d.Rows.Count)
                    {
                        var row = d.Rows[i];
                        string newId = row["id_user"].ToString();
                        if (currentChatIds[i] != newId)
                        {
                            currentChatIds[i] = newId;
                            anyChange = true;
                        }
                    }
                    else
                    {
                        if (currentChatIds[i] != null)
                        {
                            currentChatIds[i] = null;
                            anyChange = true;
                        }
                    }
                }

                if (anyChange)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < d.Rows.Count)
                        {
                            var row = d.Rows[i];
                            string newId = row["id_user"].ToString();
                            string newName = row["name"].ToString();
                            Image newImage = Properties.Resources.usuario;
                            if (row["image"] as byte[] != null)
                            {
                                newImage = Utiles.ByteArrayToImage(row["image"] as byte[]);
                            }

                            labelsIdChat[i].Text = newId;
                            labelsNombre[i].Text = newName;
                            pictureBoxes[i].Image = newImage;
                        }
                        else
                        {
                            labelsIdChat[i].Text = "";
                            labelsNombre[i].Text = "";
                            pictureBoxes[i].Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los chats: {ex.Message}");
            }
        }


        private async void pnl1_Click(object sender, EventArgs e)
        {
            if (lblIdChat1.Text != "")
            {
                MostrarPanelesChat();
                fLPanelChat.Controls.Clear();
                mensajesCargados.Clear();
                idChatSeleccionado = int.Parse(lblIdChat1.Text.ToString());
                lblNombreChatActivo.Text = lblNombre1.Text;
                pcbImagen5.Image = pcbImagen1.Image;
                await ChatMensajes();
            }
        }


        private void pnl1_MouseLeave(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.White;
        }

        private async void pnl2_Click(object sender, EventArgs e)
        {
            if (lblIdChat2.Text != "")
            {
                MostrarPanelesChat();
                fLPanelChat.Controls.Clear();
                mensajesCargados.Clear();
                idChatSeleccionado = int.Parse(lblIdChat2.Text.ToString());
                lblNombreChatActivo.Text = lblNombre2.Text;
                pcbImagen5.Image = pcbImagen2.Image;
                await ChatMensajes();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((paginaActual + 1) * elementosPorPagina < totalChats)
            {
                paginaActual++;
                ActualizarPagina();
                CargarUltimosChats();
            }
            else
            {
                MessageBox.Show("Has llegado a la última página de chats.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 0)
            {
                paginaActual--;
                ActualizarPagina();
                CargarUltimosChats();
            }

        }

        private async void pnl3_Click(object sender, EventArgs e)
        {
            if (lblIdChat3.Text != "")
            {
                MostrarPanelesChat();
                fLPanelChat.Controls.Clear();
                mensajesCargados.Clear();
                idChatSeleccionado = int.Parse(lblIdChat3.Text.ToString());
                lblNombreChatActivo.Text = lblNombre3.Text;
                pcbImagen5.Image = pcbImagen3.Image;
                await ChatMensajes();
            }
        }

        private async void pnl4_Click(object sender, EventArgs e)
        {
            if (lblIdChat4.Text != "")
            {
                MostrarPanelesChat();
                fLPanelChat.Controls.Clear();
                mensajesCargados.Clear();
                idChatSeleccionado = int.Parse(lblIdChat4.Text.ToString());
                lblNombreChatActivo.Text = lblNombre4.Text;
                pcbImagen5.Image = pcbImagen4.Image;
                await ChatMensajes();
            }
        }

        private void btnCerrarChat_Click(object sender, EventArgs e)
        {
            this.pnlChat.Visible = false;
            fLPanelChat.Controls.Clear();
            pnlInfoChat.Visible = false;
        }
    }
}
