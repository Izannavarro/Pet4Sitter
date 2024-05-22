using pet4sitter.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter
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

        private void FrmAdminProductos_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();

            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                LimpiarTablaProductos();
                ConBD.CerrarConexion();
                
            }
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

        private bool ValidarDatos()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingresa Nombre!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingresa una Descripcion del producto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingresa un Precio al producto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string nombre = txtNombre.Text;
                int cant = Convert.ToInt32(nudCant.Value);
                double precio = Convert.ToDouble(txtPrecio.Text);
                string descrip = txtDescripcion.Text;
                Image image = ptbImagen.Image;

                Producto p1 = new Producto(null, nombre, cant, precio, descrip, image);

                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    Producto.AnyadirProducto(p1);
                    LimpiarTablaProductos();
                    ConBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos!");
                }
            }
        }

        private void LimpiarTablaProductos()
        {
            dgvProductos.DataSource = null;
            // Limpia las filas
            dgvProductos.Rows.Clear();

            // Asigna el nuevo DataSource
            dgvProductos.DataSource = Producto.CantidadProductos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                int id = Convert.ToInt32(lblId.Text);
                Producto.EliminarProducto(id);
                LimpiarTablaProductos();
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos!");
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                lblId.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtPrecio.Text = fila.Cells[2].Value.ToString();
                nudCant.Value = Convert.ToUInt32(fila.Cells[3].Value.ToString());
                txtDescripcion.Text = fila.Cells[4].Value.ToString();             
                ptbImagen.Image = (Image)fila.Cells[5].Value;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int cant = Convert.ToInt32(nudCant.Value);
            double precio = Convert.ToDouble(txtPrecio.Text);
            string descrip = txtDescripcion.Text;
            Image img = ptbImagen.Image;
            int id = int.Parse(lblId.Text);

            Producto p1 = new Producto(id, nombre, cant, precio, descrip, img);


            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                Producto.ActualizarProducto(p1);
                LimpiarTablaProductos();
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos!");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
