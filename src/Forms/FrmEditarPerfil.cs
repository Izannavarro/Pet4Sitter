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
    public partial class FrmEditarPerfil : Form
    {
        public FrmEditarPerfil()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEditarPerfil_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Data.CurrentUser.Name;
            txtApellido.Text = Data.CurrentUser.Surname;
            txtContrasenya.Clear();
            txtEmail.Text = Data.CurrentUser.Email;
            txtLocalizacion.Text = Data.CurrentUser.Location;
            if (Data.CurrentUser.Image != null)
            {
                ptbImagen.Image = Utiles.ByteArrayToImage(Data.CurrentUser.Image);
            }

            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AplicarIdioma()
        {
            //    lblNombre.Text = Resources.Recursos_Localizable.FrmEditarPerfil.lblNombre;
            //    lblApellido.Text = Resources.Recursos_Localizable.FrmEditarPerfil.lblApellido;
            //    lblLocalizacion.Text = Resources.Recursos_Localizable.FrmEditarPerfil.lblLocalizacion;
            //    lblEmail.Text = Resources.Recursos_Localizable.FrmEditarPerfil.lblEmail;
            //    label7.Text = Resources.Recursos_Localizable.FrmEditarPerfil.label7;
            //    btnFoto.Text = Resources.Recursos_Localizable.FrmEditarPerfil.btnFoto;
            //    btnVolver.Text = Resources.Recursos_Localizable.FrmEditarPerfil.btnVolver;
            //    btnGuardar.Text = Resources.Recursos_Localizable.FrmEditarPerfil.btnGuardar;
        }

    private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Cargar la imagen seleccionada en un objeto Image
                    Image imagenSeleccionada = Image.FromFile(openFileDialog.FileName);

                    // Aquí podrías mostrar la imagen seleccionada en un PictureBox si lo deseas
                    ptbImagen.Image = imagenSeleccionada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
                ptbImagen.Enabled = true;
            }
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string oldPass = Data.CurrentUser.Password;
            double oldLat = (double)Data.CurrentUser.Latitud;
            double oldLong = (double)Data.CurrentUser.Longitud;
            string localizacion = txtLocalizacion.Text;
            string email = txtEmail.Text;
            string contra;
            string nombre = txtNombre.Text;
            string apellidos = txtApellido.Text;
            double? lat = Data.CurrentUser.Latitud;
            double? longi = Data.CurrentUser.Longitud;

            if (txtLocalizacion.Text != Data.CurrentUser.Location)
            {
                var coordenadas = await GeoLocalizacion.ObtenerCoordenadasAsync(txtLocalizacion.Text);

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
            if (txtContrasenya.Text != "")
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtContrasenya.Text);
                contra = hashedPassword;
            }
            else
            {
                contra = oldPass;
            }


            byte[] imgFinal = Data.CurrentUser.Image;
            if (ptbImagen.Enabled)
            {
                imgFinal = Utiles.ImageToByteArray(ptbImagen.Image);
            }

            int id = Data.CurrentUser.IdUser.Value;

            User u = new User(id, null, nombre, apellidos, email, null, contra, localizacion, null, null, null, imgFinal, lat, longi);

            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                User.ActualizarUsuario(u);
                ConBD.CerrarConexion();
                MessageBox.Show("Tu usuario: " + u.Name + " ha sido actualizado con éxito!");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
