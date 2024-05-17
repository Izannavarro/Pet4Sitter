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
            btnEliminar.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.btnEliminar_Text;
            lblDireccion.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblDireccion_Text;
            lblTarjeta.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblTarjeta_Text;
            lblConfiguracionAvanzada.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblConfiguracionAvanzada_Text;
            lblTitular.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblTitular_Text;
            lblNumero.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblNumero_Text;
            lblFecha.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblFecha_Text;
            lblCVC.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblCVC_Text;
            btnGuardar.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.btnGuardar_Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show();
        }

        private void FrmEditarTarjeta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
