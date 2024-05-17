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
    public partial class FrmAdminUsuarios : Form
    {
        public FrmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show();
        }

        private void FrmAdminUsuarios_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            btnVolver.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.btnVolver_Text;
            lblUsuarioss.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.lblUsuarioss_Text;
            btnEliminarUsuario.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.btnEliminarUsuario_Text;
            btnEditar.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.btnEditar_Text;
            button2.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.button2_Text;
            lblUsuario.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.lblUsuario_Text;
            label1.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label1_Text;
            label8.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label8_Text;
            label7.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label7_Text;
            label6.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label6_Text;
            label4.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label4_Text;
            label3.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label3_Text;
            label10.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label10_Text;
            label9.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label9_Text;
        }

        private void FrmAdminUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
