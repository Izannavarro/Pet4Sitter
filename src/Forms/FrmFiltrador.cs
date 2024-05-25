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

        private void FrmFiltrador_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            ModoOscuro();
            AsignarComboBox();
        }

        private void AsignarComboBox()
        {
            cmbDistancia.SelectedIndex = 0;
            cmbDistanciaAscDesc.SelectedIndex = 0;
            cmbOrdenarPrecio.SelectedIndex = 1;
            cmbPrecioAscDesc.SelectedIndex = 0;
            cmbPrecioAscDesc.Visible = false;
        }

        private void ModoOscuro()
        {
            if (Data.DarkMode)
            {
                this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
                this.BackColor = Color.DarkGreen;
            }
        }

        private void AplicarIdioma()
        {
            lblFiltros.Text = Resources.Recursos_Localizable.FrmFiltrador.lblFiltros_Text;
            lblRango.Text = Resources.Recursos_Localizable.FrmFiltrador.lblRango_Text;
            lblDesde.Text = Resources.Recursos_Localizable.FrmFiltrador.lblDesde_Text;
            lblHasta.Text = Resources.Recursos_Localizable.FrmFiltrador.lblHasta_Text;
            btnBuscar.Text = Resources.Recursos_Localizable.FrmFiltrador.btnBuscar_Text;
            btnBorrar.Text = Resources.Recursos_Localizable.FrmFiltrador.btnBorrar_Text;
            lblOrdenarPorDistancia.Text = Resources.Recursos_Localizable.FrmFiltrador.lblOrdenarPorDistancia_Text;
            lblOrdenarPrecio.Text = Resources.Recursos_Localizable.FrmFiltrador.lblOrdenarPrecio_Text;
            cmbDistanciaAscDesc.Text = Resources.Recursos_Localizable.FrmFiltrador.cmbDistanciaAscDesc_Text;
            cmbPrecioAscDesc.Text = Resources.Recursos_Localizable.FrmFiltrador.cmbPrecioAscDesc_Text;
            cmbOrdenarPrecio.Text = Resources.Recursos_Localizable.FrmFiltrador.cmbOrdenarPrecio_Text;
            cmbDistancia.Text = Resources.Recursos_Localizable.FrmFiltrador.cmbDistancia_Text;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool ordenDist = false;
            string ordenDistOrden = "";
            bool ordenPrecio = false;
            string ordenPrecioOrden = "";
            if (ConBD.Conexion != null)
            {
                if (cmbDistancia.SelectedIndex == 0)
                {
                    ordenDist = true;
                    if (cmbDistanciaAscDesc.SelectedIndex == 0)
                    {
                        ordenDistOrden = "ASC";
                    }
                    else
                    {
                        ordenDistOrden = "DESC";
                    }
                }

                if (cmbOrdenarPrecio.SelectedIndex == 0)
                {
                    ordenPrecio = true;
                    if (cmbPrecioAscDesc.SelectedIndex == 0)
                    {
                        ordenPrecioOrden = "ASC";
                    }
                    else
                    {
                        ordenPrecioOrden = "DESC";
                    }
                }

                ConBD.AbrirConexion();
                List<User> lUser = User.ObtenerUsuariosCercanos(Data.CurrentUser.Latitud, Data.CurrentUser.Longitud, (double)nudDesde.Value, (double)nudHasta.Value, ordenDist, ordenDistOrden, ordenPrecio, ordenPrecioOrden, 0, 3);
                ConBD.CerrarConexion();
                FrmResultadoFiltrado frmResultadoFiltrado = new FrmResultadoFiltrado(lUser, (double)nudDesde.Value, (double)nudHasta.Value, ordenDist, ordenDistOrden, ordenPrecio, ordenPrecioOrden);
                frmResultadoFiltrado.Show();
                this.Dispose();
            }
        }

        private void cmbDistancia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDistancia.SelectedIndex == 0)
            {
                cmbDistanciaAscDesc.Visible = true;
            }
            else
            {
                cmbDistanciaAscDesc.Visible = false;
            }
        }

        private void cmbOrdenarPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrdenarPrecio.SelectedIndex == 1)
            {
                cmbPrecioAscDesc.Visible = false;
            }
            else
            {
                cmbPrecioAscDesc.Visible = true;
            }
        }

        private void FrmFiltrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
