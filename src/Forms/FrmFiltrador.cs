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
using pet4sitter.Clases;

namespace pet4sitter
{
    public partial class FrmFiltrador : Form
    {
        public FrmFiltrador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmFiltrador_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblFiltros.Text = Resources.Recursos_Localizable.FrmFiltrador.lblFiltros_Text;
            lblRango.Text = Resources.Recursos_Localizable.FrmFiltrador.lblRango_Text;
            lblDesde.Text = Resources.Recursos_Localizable.FrmFiltrador.lblDesde_Text;
            lblHasta.Text = Resources.Recursos_Localizable.FrmFiltrador.lblHasta_Text;
            btnBuscar.Text = Resources.Recursos_Localizable.FrmFiltrador.btnBuscar_Text;
            btnBorrar.Text = Resources.Recursos_Localizable.FrmFiltrador.btnBorrar_Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmFiltrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                List<User> lUser = User.ObtenerUsuariosCercanos(Data.CurrentUser.Latitud, Data.CurrentUser.Longitud, (double)nudDesde.Value, (double)nudHasta.Value,0,3);
                ConBD.CerrarConexion();
                FrmResultadoFiltrado frmResultadoFiltrado = new FrmResultadoFiltrado(lUser);
                frmResultadoFiltrado.Show();
                //this.Close();
            }
        }
    }
}
