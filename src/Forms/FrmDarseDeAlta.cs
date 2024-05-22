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

namespace pet4sitter
{
    public partial class FrmDarseDeAlta : Form
    {
        public FrmDarseDeAlta()
        {
            InitializeComponent();
        }

        private void FrmDarseDeAlta_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            
        }

        private void AplicarIdioma()
        {
            lblPrecioDia.Text = Resources.Recursos_Localizable.FrmAlta.lblPrecioDia_Text;
            btnGuardar.Text = Resources.Recursos_Localizable.FrmAlta.btnGuardar_Text;
            btnVolver.Text = Resources.Recursos_Localizable.FrmAlta.btnVolver_Text;
            lblDarseAlta.Text = Resources.Recursos_Localizable.FrmAlta.lblTittle_Text;
        }

        private void FrmDarseDeAlta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
