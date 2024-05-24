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
    public partial class FrmEditarTarjeta : Form
    {
        public FrmEditarTarjeta()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarTarjeta_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            btnVolver.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.btnVolver_Text;
            lblConfiguracionAvanzada.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblConfiguracionAvanzada_Text;
            lblTitular.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblTitular_Text;
            lblNumero.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblNumero_Text;
            lblFecha.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblFecha_Text;
            lblCVC.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblCVC_Text;
            btnGuardar.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.btnGuardar_Text;
        }

        private void FrmEditarTarjeta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
