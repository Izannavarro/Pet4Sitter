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
            double? precio = Data.CurrentUser.Precio;
            string loca = txtDireccion.Text;
            double oldLat = (double)Data.CurrentUser.Latitud;
            double oldLong = (double)Data.CurrentUser.Longitud;
            double? lat = null;
            double? longi = null;

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
                        MessageBox.Show("Si");
                        if (coordenadas.Latitude.Value != oldLat)
                        {
                            lat = coordenadas.Latitude.Value;
                        }
                        else
                        {
                            lat = oldLat;
                        }

                        if (coordenadas.Longitude.Value != oldLong)
                        {
                            longi = coordenadas.Longitude.Value;
                        }
                        else
                        {
                            longi = oldLong;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Direccion INCORRECTA");
                    }
                }
            }

            User u = new User(Data.CurrentUser.IdUser,Data.CurrentUser.IdGoogle,Data.CurrentUser.Name, Data.CurrentUser.Surname, Data.CurrentUser.Email,Data.CurrentUser.Dni,Data.CurrentUser.Password,precio,loca,Data.CurrentUser.Premium,Data.CurrentUser.Sitter,Data.CurrentUser.Admin,Data.CurrentUser.Image,lat,longi);
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                User.ActualizarUsuario(u);
                ConBD.CerrarConexion();
                MessageBox.Show("Localización del Usuario Actualizada con éxito!");
            }
        }
    }
}
