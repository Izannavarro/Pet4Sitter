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

namespace piTest.Forms
{
    public partial class FrmAdminNoticias : Form
    {
        public FrmAdminNoticias()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAdminNoticias_Load(object sender, EventArgs e)
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

        private void FrmAdminNoticias_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void AplicarIdioma()
        {
            btnVolver.Text = Resources.Recursos_Localizable.FrmAdminNoticias.btnVolver_Text;
            btnEliminar.Text = Resources.Recursos_Localizable.FrmAdminNoticias.btnEliminar_Text;
            btnEditar.Text = Resources.Recursos_Localizable.FrmAdminNoticias.btnEditar_Text;
            btnFoto.Text = Resources.Recursos_Localizable.FrmAdminNoticias.btnFoto_Text;
            btnAnyadir.Text = Resources.Recursos_Localizable.FrmAdminNoticias.btnAnyadir_Text;
            lblContenido.Text = Resources.Recursos_Localizable.FrmAdminNoticias.lblContenido_Text;
            lblIdNoticias.Text = Resources.Recursos_Localizable.FrmAdminNoticias.lblIdNoticias_Text;
            lblTitular.Text = Resources.Recursos_Localizable.FrmAdminNoticias.lblTitular_Text;
            label2.Text = Resources.Recursos_Localizable.FrmAdminNoticias.label2_Text;
            label3.Text = Resources.Recursos_Localizable.FrmAdminNoticias.label3_Text;
            label6.Text = Resources.Recursos_Localizable.FrmAdminNoticias.label6_Text;
            btnSiguiente.Text = Resources.Recursos_Localizable.FrmAdminNoticias.btnSiguiente_Text;
            btnAnterior.Text = Resources.Recursos_Localizable.FrmAdminNoticias.btnAnterior_Text;
        }

    }
}
