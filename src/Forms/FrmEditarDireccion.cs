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
    public partial class FrmEditarDireccion : Form
    {
        public FrmEditarDireccion()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarDireccion_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show();
        }
        private void AplicarIdioma()
        {
            lblDireccion.Text = Resources.Recursos_Localizable.FrmEditarDireccion.lblDireccion_Text;
            lblCalle.Text = Resources.Recursos_Localizable.FrmEditarDireccion.lblCalle_Text;
            lblEditarDireccion.Text = Resources.Recursos_Localizable.FrmEditarDireccion.lblEditarDireccion_Text;
            btnVolver.Text = Resources.Recursos_Localizable.FrmEditarDireccion.btnVolver_Text;
            btnGuardar.Text = Resources.Recursos_Localizable.FrmEditarDireccion.btnGuardar_Text;
            btnEliminar.Text = Resources.Recursos_Localizable.FrmEditarDireccion.btnEliminar_Text;
        }

        private void FrmEditarDireccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
