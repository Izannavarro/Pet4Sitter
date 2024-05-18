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
    public partial class FrmTienda : Form
    {
        public FrmTienda()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show(); // Muestra el formulario FrmConfiguracion
        }

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblDescripcion.Text = Resources.Recursos_Localizable.FrmTienda.lblDescripcion_Text;
            btnAñadir.Text = Resources.Recursos_Localizable.FrmTienda.btnAñadir_Text;
        }

        private void FrmTienda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
