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
            CargarResultados();
        }

        private void CargarResultados()
        {
            if (users.Count > 0)
            {
                lblNombreCuidador1.Text = users[0].Name;
            }

            if (users.Count > 1)
            {
                lblNombreCuidador2.Text = users[1].Name;
            }

            if (users.Count > 2)
            {
                lblNombreCuidador3.Text = users[2].Name;
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
            lblDescripcion4.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion4_Text;
            lblNombreCuidador3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion3_Text;
            lblNombreCuidador2.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion2_Text;
            lblNombreCuidador1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion1_Text;
            btnSiguiente.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnSiguiente_Text;
            btnAnterior.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnAnterior_Text;
            lblValoracion.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblValoracion_Text;
            lblDireccion.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDireccion_Text;
            lblHasta.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblHasta_Text;
            lblDesde.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDesde_Text;
            button1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.button1_Text;
            button3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.button3_Text;
            btnConf.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnConf_Text;
            btnAñadir.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.btnAñadir_Text;
        }

        private void FrmResultadoFiltrado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
