using pet4sitter.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            txtContrasenya.Text = Data.CurrentUser.Password;
            txtEmail.Text = Data.CurrentUser.Email;
            txtLocalizacion.Text = Data.CurrentUser.Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string localizacion = txtLocalizacion.Text;
            string email = txtEmail.Text;
            string contra = txtContrasenya.Text;
            byte[] imgArr = Utiles.ImageToByteArray(ptbImagen.Image);
            int id = Data.CurrentUser.IdUser.Value;

            User u = new User(id, null, nombre, apellidos, email, null, contra, localizacion, null, null, null, imgArr, null, null);

            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                User.ActualizarUsuario(u);
                ConBD.CerrarConexion();
            }
        }
    }
}
