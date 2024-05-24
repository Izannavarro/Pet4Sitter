using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pet4sitter.Clases;
using System.Windows.Forms;
using System.Diagnostics;
using pet4sitter.Resources;

namespace pet4sitter
{
    public partial class FrmResultadoFiltrado : Form
    {
        List<User> users = new List<User>();
        private int paginaActual = 0;
        private int elementosPorPagina = 3;
        private int totalUsuarios = 0;

        double? latitudReferencia = Data.CurrentUser.Latitud;  // Obtén la latitud de referencia
        double? longitudReferencia = Data.CurrentUser.Longitud;  // Obtén la longitud de referencia
        double precioDesde;
        double precioHasta;
        bool ordenDist;
        string ordenDistOrden;
        bool ordenPrecio;
        string ordenPrecioOrden;
        public FrmResultadoFiltrado()
        {
            InitializeComponent();
        }

        public FrmResultadoFiltrado(List<User> luser,double precioDesde,double precioHasta,bool ordenDist, string ordenDistOrden, bool ordenPrecio, string ordenPrecioOrden)
        {
            InitializeComponent();
            users = luser;
            this.precioDesde = precioDesde;  // Obtén el precio mínimo
            this.precioHasta = precioHasta;  // Obtén el precio máximo
            this.ordenDist = ordenDist;
            this.ordenDistOrden = ordenDistOrden;
            this.ordenPrecio = ordenPrecio;
            this.ordenPrecioOrden = ordenPrecioOrden;
        }


        private void FrmResultadoFiltrado_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                totalUsuarios = User.ContarUsuariosCercanos(latitudReferencia, longitudReferencia, precioDesde, precioHasta);
                ActualizarInformacionPagina();
                ConBD.CerrarConexion();
            }

            CargarResultados();

        }

        private void CargarResultados()
        {
            if (users.Count > 0)
            {
                User user = users[0];
                lblNombreCuidador1.Text = user.Name;
                lblIdUser1.Visible = false;
                lblResPrecio1.Text = $"{user.Precio.ToString()} EUR";
                lblPrecio1.Visible = true;
                lblResPrecio1.Visible = true;
                lblIdUser1.Text =  user.IdUser.ToString();
                lblResUbi1.Text = user.Location;
                lblResUbi1.Links.Clear();
                string lat = user.Latitud.ToString().Replace(',', '.');
                string lon = user.Longitud.ToString().Replace(',', '.');
                lblResUbi1.Links.Add(0, user.Location.Length, $"https://maps.google.com/?q={lat},{lon}");
                btnEnviarMensajeChat1.Visible = true;
                lblResUbi1.Visible = true;
                lblUbicacion1.Visible = true;
                if(user.Image != null)
                {
                    pcbCuidador1.Image = Utiles.ByteArrayToImage(user.Image);
                }
            }

            if (users.Count > 1)
            {
                User user = users[1];
                lblNombreCuidador2.Text = user.Name;
                lblIdUser2.Visible = false;
                lblIdUser2.Text = user.IdUser.ToString();
                lblResPrecio2.Text = $"{user.Precio.ToString()} EUR";
                lblPrecio2.Visible = true;
                lblResPrecio2.Visible = true;
                lblResUbi2.Text = user.Location;
                lblResUbi2.Links.Clear();
                string lat2 = user.Latitud.ToString().Replace(',', '.');
                string lon2 = user.Longitud.ToString().Replace(',', '.');
                lblResUbi2.Links.Add(0, user.Location.Length, $"https://maps.google.com/?q={lat2},{lon2}");
                btnEnviarMensajeChat2.Visible = true;
                lblResUbi2.Visible = true;
                lblUbicacion2.Visible = true;
                if (user.Image != null)
                {
                    pcbCuidador2.Image = Utiles.ByteArrayToImage(user.Image);
                }
            }

            if (users.Count > 2)
            {
                User user = users[2];
                lblNombreCuidador3.Text = user.Name;
                lblIdUser3.Visible = false;
                lblIdUser3.Text = user.IdUser.ToString();
                lblResPrecio3.Text = $"{user.Precio.ToString()} EUR";
                lblPrecio3.Visible = true;
                lblResPrecio3.Visible = true;
                lblResUbi3.Text = user.Location;
                lblResUbi3.Links.Clear();
                string lat3 = user.Latitud.ToString().Replace(',', '.');
                string lon3 = user.Longitud.ToString().Replace(',', '.');
                lblResUbi3.Links.Add(0, user.Location.Length, $"https://maps.google.com/?q={lat3},{lon3}");
                btnEnviarMensajeChat3.Visible = true;
                lblResUbi3.Visible = true;
                lblUbicacion3.Visible = true;
                if (user.Image != null)
                {
                    pcbCuidador3.Image = Utiles.ByteArrayToImage(user.Image);
                }
            }
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show();
        }
        private void AplicarIdioma()
        {
            lblNombreCuidador3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblNombreCuidador3_Text;
            lblNombreCuidador2.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblNombreCuidador2_Text;
            lblNombreCuidador1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblNombreCuidador1_Text;
            btnSiguiente.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnSiguiente_Text;
            btnAnterior.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnAnterior_Text;
            lblPaginaActual.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblPaginaActual_Text;
            lblResPrecio3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblResPrecio3_Text;
            lblPrecio3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblPrecio3_Text;
            lblUbicacion3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblUbicacion3_Text;
            btnEnviarMensajeChat3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnEnviarMensajeChat3_Text;
            lblResPrecio2.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblResPrecio2_Text;
            lblPrecio2.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblPrecio2_Text;
            lblUbicacion2.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblUbicacion2_Text;
            btnEnviarMensajeChat2.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnEnviarMensajeChat2_Text;
            lblResPrecio1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblResPrecio1_Text;
            lblPrecio1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblPrecio1_Text;
            lblUbicacion1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblUbicacion1_Text;
            btnEnviarMensajeChat1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnEnviarMensajeChat1_Text;
            lblNombreCuidador1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblNombreCuidador1_Text;
            lblPaginaActual.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblPaginaActual_Text;
        }


        private void FrmResultadoFiltrado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((paginaActual + 1) * elementosPorPagina >= totalUsuarios)
            {
                MessageBox.Show("Has llegado a la última página de resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                paginaActual++;
                RestaurarResultadosBusquedaCuidador();
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    CargarPagina();
                    ActualizarInformacionPagina();
                    ConBD.CerrarConexion();
                }
            }
        }

        private void RestaurarResultadosBusquedaCuidador()
        {
            lblNombreCuidador1.Text = "Sin Resultados";
            pcbCuidador1.Image = Properties.Resources.usuario;
            lblUbicacion1.Visible = false;
            lblPrecio1.Visible = false;
            lblResPrecio1.Text = "";
            lblResUbi1.Text = "";
            btnEnviarMensajeChat1.Visible = false;

            lblNombreCuidador2.Text = "Sin Resultados";
            pcbCuidador2.Image = Properties.Resources.usuario;
            lblUbicacion2.Visible = false;
            lblPrecio2.Visible = false;
            lblResPrecio2.Text = "";
            lblResUbi2.Text = "";
            btnEnviarMensajeChat2.Visible = false;

            lblNombreCuidador3.Text = "Sin Resultados";
            pcbCuidador3.Image = Properties.Resources.usuario;
            lblUbicacion3.Visible = false;
            lblPrecio3.Visible = false;
            lblResPrecio3.Text = "";
            lblResUbi3.Text = "";
            btnEnviarMensajeChat3.Visible = false;

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 0)
            {
                paginaActual--;
                RestaurarResultadosBusquedaCuidador();
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    CargarPagina();
                    ActualizarInformacionPagina();
                }
                ConBD.CerrarConexion();
            }
        }

        private void CargarPagina()
        {

            users = User.ObtenerUsuariosCercanos(latitudReferencia, longitudReferencia, precioDesde, precioHasta,ordenDist,ordenDistOrden,ordenPrecio,ordenPrecioOrden, paginaActual * elementosPorPagina, elementosPorPagina);
            CargarResultados();
        }

        private void btnEnviarMensajeChat1_Click(object sender, EventArgs e)
        {
            FrmChat chat = new FrmChat(int.Parse(lblIdUser1.Text));
            chat.Show();
            this.Dispose();
        }

        private void btnEnviarMensajeChat2_Click(object sender, EventArgs e)
        {
            FrmChat chat = new FrmChat(int.Parse(lblIdUser2.Text));
            chat.Show();
            this.Dispose();
        }

        private void btnEnviarMensajeChat3_Click(object sender, EventArgs e)
        {
            FrmChat chat = new FrmChat(int.Parse(lblIdUser3.Text));
            chat.Show();
            this.Dispose();
        }

        private void lblResUbi1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(url);
            }
        }


        private void lblResUbi2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        private void lblResUbi3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }
        private void ActualizarInformacionPagina()
        {
            int totalPaginas = (int)Math.Ceiling((double)totalUsuarios / elementosPorPagina);
            lblPaginaActual.Text = $"Página {paginaActual + 1} de {totalPaginas}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            totalUsuarios = User.ContarUsuariosCercanos(latitudReferencia, longitudReferencia, precioDesde, precioHasta);
        }
    }
}
