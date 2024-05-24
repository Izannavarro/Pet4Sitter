using pet4sitter.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void FrmInicio_Load(object sender, EventArgs e)
        {
            ModoOscuro();
            AplicarIdioma();
            if ((bool)Data.CurrentUser.Premium)
            {
                await MostrarNoticia();
                pnlNoticiaPremium.Visible = false;
            }
            else
            {
                pnlNoticiaPremium.Visible = true;
                pnlNoticiaPremium.BringToFront();
            }
            CargarProductosDestacados();
            CargarUltimosChats();

            if ((bool)Data.CurrentUser.Admin)
            {
                btnAdmin.Visible = true;
            }
        }

        private void AplicarIdioma()
        {
            lblPremium.Text = Resources.Recursos_Localizable.FrmInicio.lbl;
            linkNoticia.Text = Resources.Recursos_Localizable.FrmInicio.link;
        }

        private void ModoOscuro()
        {
            if (Data.DarkMode)
            {
                this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
                this.BackColor = Color.DarkGreen;
            }
        }
        private void CargarProductosDestacados()
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                string query = "Select * from products order by rand() limit 2";
                List<Producto> lprod = Producto.ListarProductos(query);
                if (lprod.Count > 0)
                {
                    lblProductoDestacado1.Text = lprod[0].NombreProducto;
                    lblPrecioProductoDestacado1.Text = lprod[0].Precio.ToString();
                    pcbProductoDestacado1.Image = lprod[0].UrlImagen;
                }

                if (lprod.Count > 1)
                {
                    lblProductoDestacado2.Text = lprod[1].NombreProducto;
                    lblPrecioProductoDestacado2.Text = lprod[1].Precio.ToString();
                    pcbProductoDestacado2.Image = lprod[1].UrlImagen;
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }

        private void lblPrecioProductoDestacado2_Click(object sender, EventArgs e)
        {

        }

        private async Task MostrarNoticia()
        {
            try
            {
                var newsFetcher = new NewsFetcher(Data.tokenNoticias);
                Noticia noticia = await newsFetcher.FetchAnimalNews();
                lblTítuloNoticia.Text = ($"Título: {noticia.Titulo}");
                lblCuerpoNoticia.Text = ($"Descripción: {noticia.Descripcion.Substring(0, noticia.Descripcion.LastIndexOf('[')).Trim()}");
                var link = new LinkLabel.Link();
                link.LinkData = noticia.Url; // El URL que deseas abrir
                linkNoticia.Links.Add(link);
                linkNoticia.LinkClicked += (sender, e) =>
                {
                    // Abre el enlace en el navegador predeterminado cuando se hace clic en el LinkLabel
                    System.Diagnostics.Process.Start(e.Link.LinkData as string);
                };
                Console.WriteLine($"URL: {noticia.Url}");
                string urlImagen = noticia.UrlImagen; // Suponiendo que noticia.UrlImagen es la URL de la imagen

                pcbNoticia.Load(urlImagen);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void CargarUltimosChats()
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                string query = $@"
    SELECT *
    FROM chat c
    INNER JOIN (
        SELECT id_sender, MAX(date) AS max_date
        FROM chat
        WHERE id_receiver = {Data.CurrentUser.IdUser} OR id_sender = {Data.CurrentUser.IdUser} and id_sender != {Data.CurrentUser.IdUser}
        GROUP BY id_sender
        ORDER BY max_date DESC
        LIMIT 3
    ) AS sub ON c.id_sender = sub.id_sender AND c.date = sub.max_date
    INNER JOIN users u ON c.id_sender = u.id_user
    ORDER BY c.date DESC;
";
                List<User> users = User.ListarUsuarios(query);
                List<Mensaje> lMens = Mensaje.ListarMensajes(query);
                if (users.Count > 0)
                {
                    lblNombreChat1.Text = users[0].Name;

                    if (users[0].Image != null)
                    {
                        pcbChat1.Image = Utiles.ByteArrayToImage(users[0].Image); // ??
                    }
                    lblMensaje1.Text =  lMens[0].Message;
                    lblIdChat1.Text = users[0].IdUser.ToString();
                }

                if (users.Count > 1)
                {
                    if (users[1] != null)
                    {
                        lblNombreChat2.Text = users[1].Name;
                        if (users[1].Image != null)
                        {
                            pcbChat2.Image = Utiles.ByteArrayToImage(users[1].Image); // ??
                        }
                    }
                    lblMensaje2.Text = lMens[1].Message;
                    lblIdChat2.Text = users[1].IdUser.ToString();
                }

                if (users.Count > 2)
                {

                    if (users[2] != null) { 

                        lblNombreChat3.Text = users[2].Name;
                        if (users[2].Image != null)
                        {
                            pcbChat3.Image = Utiles.ByteArrayToImage(users[2].Image); // ??
                        }
                    
                    }
                    lblMensaje3.Text = lMens[2].Message;
                    lblIdChat3.Text = users[2].IdUser.ToString();
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }

        private void pnlChat1_MouseHover(object sender, EventArgs e)
        {
            if (Data.DarkMode)
            {
                pnlChat1.BackColor = Color.DarkGreen;
                lblNombreChat1.ForeColor = Color.White;
                lblMensaje1.ForeColor = Color.White;
            }
            else
            {
                pnlChat1.BackColor = Color.LightGreen;
            }
        }

        private void pnlChat1_MouseLeave(object sender, EventArgs e)
        {
            pnlChat1.BackColor = Color.White;
            lblNombreChat1.ForeColor = Color.Black;
            lblMensaje1.ForeColor = Color.Black;
        }


        private void pnlChat3_MouseHover(object sender, EventArgs e)
        {
            if (Data.DarkMode)
            {
                pnlChat3.BackColor = Color.DarkGreen;
                lblNombreChat3.ForeColor = Color.White;
                lblMensaje3.ForeColor = Color.White;
            }
            else
            {
                pnlChat3.BackColor = Color.LightGreen;
            }
        }

        private void pnlChat2_MouseHover(object sender, EventArgs e)
        {
            if (Data.DarkMode)
            {
                pnlChat2.BackColor = Color.DarkGreen;
                lblNombreChat2.ForeColor = Color.White;
                lblMensaje2.ForeColor = Color.White;
            }
            else
            {
                pnlChat2.BackColor = Color.LightGreen;
            }
        }

        private void pnlChat2_MouseLeave(object sender, EventArgs e)
        {
            pnlChat2.BackColor = Color.White;
            lblNombreChat2.ForeColor = Color.Black;
            lblMensaje2.ForeColor = Color.Black;
        }

        private void pnlChat3_MouseLeave(object sender, EventArgs e)
        {
            pnlChat3.BackColor = Color.White;
            lblNombreChat3.ForeColor = Color.Black;
            lblMensaje3.ForeColor = Color.Black;
        }

        private void pnlChat1_Click(object sender, EventArgs e)
        {
            if (lblIdChat1.Text != "")
            {
                FrmChat frmChat = new FrmChat(int.Parse(lblIdChat1.Text));
                frmChat.Show();
                this.Dispose();
            }

        }

        private void pnlChat2_Click(object sender, EventArgs e)
        {
            if(lblIdChat2.Text != "")
            {
                FrmChat frmChat = new FrmChat(int.Parse(lblIdChat2.Text));
                frmChat.Show();
                this.Dispose();
            }
        }

        private void pnlChat3_Click(object sender, EventArgs e)
        {
            if (lblIdChat3.Text != "")
            {
                FrmChat frmChat = new FrmChat(int.Parse(lblIdChat3.Text));
                frmChat.Show();
                this.Dispose();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmInicioAdmin admin = new FrmInicioAdmin();
            admin.Show();
            this.Hide();
        }

        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
