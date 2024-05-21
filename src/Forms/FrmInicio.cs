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
                string query = $"SELECT * FROM chat c INNER JOIN users u ON c.id_sender = u.id_user WHERE id_receiver = {Data.CurrentUser.IdUser} GROUP BY id_sender LIMIT 3;";
                List<User> users = User.ListarUsuarios(query);
                if (users.Count > 0)
                {
                    lblNombreChat1.Text = users[0].Name;
                    if (users[0].Image != null)
                    {
                        pcbChat1.Image = Utiles.ByteArrayToImage(users[0].Image); // ??
                    }

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
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }

    }
}
