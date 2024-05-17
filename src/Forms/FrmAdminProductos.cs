using piTest.Clases;
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
    public partial class FrmAdminProductos : Form
    {
        public FrmAdminProductos()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show();
        }

        private void FrmAdminProductos_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            btnVolver.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnVolver_Text;
            btnEliminar.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnEliminar_Text;
            btnEditar.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnEditar_Text;
            btnFoto.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnFoto_Text;
            btnAñadir.Text = Resources.Recursos_Localizable.FrmAdminProductos.btnAñadir_Text;
            lblDescripcion.Text = Resources.Recursos_Localizable.FrmAdminProductos.lblDescripcion_Text;
            label3.Text = Resources.Recursos_Localizable.FrmAdminProductos.label3_Text;
            lblCantidad.Text = Resources.Recursos_Localizable.FrmAdminProductos.lblCantidad_Text;
            lblNombre.Text = Resources.Recursos_Localizable.FrmAdminProductos.lblNombre_Text;
            button1.Text = Resources.Recursos_Localizable.FrmAdminProductos.button1_Text;
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int cant = Convert.ToInt32(nudCant.Value);
            double precio = Convert.ToDouble(txtPrecio.Text);
            string descrip = txtDescripcion.Text;
            Image img = ptbImagen.Image;

            Producto p1 = new Producto(nombre, cant, precio, descrip, img);

            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                Producto.
                ConBD.CerrarConexion();
            }
        }
    }
}
