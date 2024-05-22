using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pet4sitter.Clases;

namespace pet4sitter.Forms
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private async void FrmTest_Load(object sender, EventArgs e)
        {
            string direccion = "Calle Lira Almussafense Nº17, Almussafes";

            try
            {
                var coordenadas = await GeoLocalizacion.ObtenerCoordenadasAsync(direccion);

                if (coordenadas.Latitude.HasValue && coordenadas.Longitude.HasValue)
                {
                    MessageBox.Show($"Coordenadas para la dirección '{direccion}':\nLatitud: {coordenadas.Latitude}\nLongitud: {coordenadas.Longitude}", "Coordenadas");
                }
                else
                {
                    MessageBox.Show($"No se encontraron coordenadas para la dirección '{direccion}'.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener coordenadas: {ex.Message}", "Error");
            }
        }
    }
}
