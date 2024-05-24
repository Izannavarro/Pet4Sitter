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

namespace pet4sitter.UserControls
{
    public partial class ProductoEnCarrito : UserControl
    {
        Form frmActual;
        public ProductoEnCarrito()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        public double Precio
        {
            get { return double.Parse(lblPrecio.Text, CultureInfo.InvariantCulture); }
            set { lblPrecio.Text = value.ToString("C", CultureInfo.CurrentCulture); }
        }

        public int Cantidad
        {
            get { return (int)nudCantidad.Value; }
            set { nudCantidad.Value = value; }
        }

        public string Descripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        public Image Imagen
        {
            get { return pbImagen.Image; }
            set { pbImagen.Image = value; }
        }


        public int Id
        {
            get { return int.Parse(lblId.Text); }
            set { lblId.Text = value.ToString(); }
        }

        private void ProductoEnCarrito_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int index = Carrito.IndiceProducto(int.Parse(lblId.Text));
            if(index >= 0)
            {
                Carrito.Productos.RemoveAt(index);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int index = Carrito.IndiceProducto(int.Parse(lblId.Text));
            Carrito.Productos[index].Cantidad = (int)nudCantidad.Value;
        }
    }
}
