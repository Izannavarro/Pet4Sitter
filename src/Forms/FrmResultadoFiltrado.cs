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

namespace pet4sitter
{
    public partial class FrmResultadoFiltrado : Form
    {
        List<User> users = new List<User>();
        private int paginaActual = 0;
        private int elementosPorPagina = 3;
        private int totalUsuarios = 0;

        double precioDesde;
        double precioHasta;
        public FrmResultadoFiltrado()
        {
            InitializeComponent();
        }

        public FrmResultadoFiltrado(List<User> luser)
        {
            InitializeComponent();
            users = luser;
        }


        private void FrmResultadoFiltrado_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();

            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                double? latitudReferencia = Data.CurrentUser.Latitud;  // Obtén la latitud de referencia
                double? longitudReferencia = Data.CurrentUser.Longitud;  // Obtén la longitud de referencia
                double precioDesde = 0;  // Obtén el precio mínimo
                double precioHasta = 1000;  // Obtén el precio máximo
                totalUsuarios = User.ContarUsuariosCercanos(latitudReferencia, longitudReferencia, precioDesde, precioHasta);
                ConBD.CerrarConexion();
            }

            CargarResultados();

        }

        private void CargarResultados()
        {
            if (users.Count > 0)
            {
                lblNombreCuidador1.Text = users[0].Name;
                lblIdUser1.Visible = false;
                lblIdUser1.Text =  users[0].IdUser.ToString();
            }

            if (users.Count > 1)
            {
                lblNombreCuidador2.Text = users[1].Name;
                lblIdUser2.Visible = false;
                lblIdUser2.Text = users[1].IdUser.ToString();
            }

            if (users.Count > 2)
            {
                lblNombreCuidador3.Text = users[2].Name;
                lblIdUser3.Visible = false;
                lblIdUser2.Text = users[2].IdUser.ToString();
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
            lblNombreCuidador3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion3_Text;
            lblNombreCuidador2.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion2_Text;
            lblNombreCuidador1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion1_Text;
            btnSiguiente.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnSiguiente_Text;
            btnAnterior.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnAnterior_Text;
            lblValoracion.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblValoracion_Text;
            lblHasta.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblHasta_Text;
            lblDesde.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDesde_Text;
            button1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.button1_Text;
            button3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.button3_Text;
            btnConf.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnConf_Text;
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
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    CargarPagina();
                    ConBD.CerrarConexion();
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 0)
            {
                paginaActual--;
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    CargarPagina();
                }
                ConBD.CerrarConexion();
            }
        }

        private void CargarPagina()
        {
            double? latitudReferencia = Data.CurrentUser.Latitud;  // Obtén la latitud de referencia
            double? longitudReferencia = Data.CurrentUser.Longitud;  // Obtén la longitud de referencia
            double precioDesde = 0;  // Obtén el precio mínimo
            double precioHasta = 1000;  // Obtén el precio máximo

            users = User.ObtenerUsuariosCercanos(latitudReferencia, longitudReferencia, precioDesde, precioHasta, paginaActual * elementosPorPagina, elementosPorPagina);
            CargarResultados();
        }

        private void btnEnviarMensajeChat1_Click(object sender, EventArgs e)
        {
            FrmChat chat = new FrmChat(int.Parse(lblIdUser1.Text));
            chat.ShowDialog();
        }
    }
}
