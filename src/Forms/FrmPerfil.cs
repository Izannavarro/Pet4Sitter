using pet4sitter.Clases;
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
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            if (Data.CurrentUser.Image != null)
            {
                pcbImagen.Image = Utiles.ByteArrayToImage(Data.CurrentUser.Image);
            }
        }

        private void AplicarIdioma()
        {
            lblUltimasValoraciones.Text = Resources.Recursos_Localizable.FrmPerfil.lblUltimasValoraciones_Text;
            lblUltimaCompra.Text = Resources.Recursos_Localizable.FrmPerfil.lblUltimaCompra_Text;
            btnEditarPerfil.Text = Resources.Recursos_Localizable.FrmPerfil.btnEditarPerfil_Text;
            btnDarAlta.Text = Resources.Recursos_Localizable.FrmPerfil.btnDarAlta_Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show(); // Muestra el formulario FrmConfiguracion
        }

        private void FrmPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            FrmEditarPerfil frm = new FrmEditarPerfil();
            frm.ShowDialog();
        }
    }
}
