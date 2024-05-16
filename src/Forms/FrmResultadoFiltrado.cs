using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piTest
{
    public partial class FrmResultadoFiltrado : Form
    {
        public FrmResultadoFiltrado()
        {
            InitializeComponent();
        }

        private void FrmResultadoFiltrado_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
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
            lblDescripcion3.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion3_Text;
            lblDescripcion2.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion2_Text;
            lblDescripcion1.Text = Resources.Recursos_Localizable.FrmResultadoFiltrado.lblDescripcion1_Text;
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
    }
}
