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
        private void AplicarIdioma()
        {
            lblDireccion.Text = Resources.Recursos_Localizable.FrmEditarDireccion.lblDireccion_Text;
            lblEditarDireccion.Text = Resources.Recursos_Localizable.FrmEditarDireccion.lblEditarDireccion_Text;
            btnVolver.Text = Resources.Recursos_Localizable.FrmEditarDireccion.btnVolver_Text;
            btnGuardar.Text = Resources.Recursos_Localizable.FrmEditarDireccion.btnGuardar_Text;
        }

        private void FrmEditarDireccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string loca = txtDireccion.Text;

            if (loca == "")
            {
                MessageBox.Show("La Dirección introducida es errónea. Introdúcela de nuevo!");
            }
            else {

                if (loca != Data.CurrentUser.Location)
                {
                    var coordenadas = await GeoLocalizacion.ObtenerCoordenadasAsync(loca);

                    if (coordenadas.Latitude.HasValue && coordenadas.Longitude.HasValue)
                    {
                        Data.CurrentPedido.Localizacion = loca;
                        MessageBox.Show("Dirección Correcta");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Direccion INCORRECTA");
                    }
                }
            }
        }
    }
}
