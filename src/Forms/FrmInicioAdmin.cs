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
    public partial class FrmInicioAdmin : Form
    {
        public FrmInicioAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show(); // Muestra el formulario FrmConfiguracion
        }

        private void FrmInicioAdmin_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            btnProductos.Text = Resources.Recursos_Localizable.FrmInicioAdmin.btnProductos_Text;
            btnNoticias.Text = Resources.Recursos_Localizable.FrmInicioAdmin.btnNoticias_Text;
            btnCerrarSesion.Text = Resources.Recursos_Localizable.FrmInicioAdmin.btnCerrarSesion_Text;
            btnUsuarios.Text = Resources.Recursos_Localizable.FrmInicioAdmin.btnUsuarios_Text;
        }

        private void FrmInicioAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
