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
    public partial class FrmCarrito : Form
    {
        public FrmCarrito()
        {
            InitializeComponent();
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblDescripcionLocalizacion.Text = Resources.Recursos_Localizable.FrmCarrito.lblDescripcionLocalizacion_Text;
            btnEliminar.Text = Resources.Recursos_Localizable.FrmCarrito.btnEliminar_Text;
            lblSubtotal.Text = Resources.Recursos_Localizable.FrmCarrito.lblSubtotal_Text;
            btnEditarPago.Text = Resources.Recursos_Localizable.FrmCarrito.btnEditarPago_Text;
            btnEditar.Text = Resources.Recursos_Localizable.FrmCarrito.btnEditar_Text;
            lblResumen.Text = Resources.Recursos_Localizable.FrmCarrito.lblResumen_Text;
            btnVolverPago.Text = Resources.Recursos_Localizable.FrmCarrito.btnVolverPago_Text;
            lblDescripcionTarjeta.Text = Resources.Recursos_Localizable.FrmCarrito.lblDescripcionTarjeta_Text;
            lblMetodo.Text = Resources.Recursos_Localizable.FrmCarrito.lblMetodo_Text;
            btnRealizar.Text = Resources.Recursos_Localizable.FrmCarrito.btnRealizar_Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show(); // Muestra el formulario FrmConfiguracion
        }

        private void FrmCarrito_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
