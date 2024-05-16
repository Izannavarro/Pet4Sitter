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
    public partial class FrmAdminProductos : Form
    {
        public FrmAdminProductos()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show();
        }

        private void FrmAdminProductos_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            btnVolver.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnVolver_Text;
            btnEliminar.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnEliminar_Text;
            btnEditar.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnEditar_Text;
            btnFoto.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnFoto_Text;
            btnAñadir.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnAñadir_Text;
            lblDescripcion.Text = Resources.Recursos_Localizable.FrmAdminProductos.lblDescripcion_Text;
            label3.Text = Resources.Recursos_Localizable.FrmAdminProductos.label3_Text;
            lblCantidad.Text = Resources.Recursos_Localizable.FrmAdminProductos.lblCantidad_Text;
            lblId.Text = Resources.Recursos_Localizable.FrmAdminProductos.lblId_Text;
            lblNombre.Text = Resources.Recursos_Localizable.FrmAdminProductos.lblNombre_Text;
            button1.Text = Resources.Recursos_Localizable.FrmAdminProductos.button1_Text;
        }

    }
}
