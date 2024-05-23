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
            get { return int.Parse(lblCantidad.Text); }
            set { lblCantidad.Text = value.ToString(); }
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
    }
}
