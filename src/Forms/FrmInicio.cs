using piTest.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piTest
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            CargarProductosDestacados();
        }
        private void CargarProductosDestacados()
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                string query = "Select * from products order by rand() limit 2";
                List<Producto> lprod = Producto.ListarProductos(query);
                if (lprod.Count > 0)
                {
                    lblProductoDestacado1.Text = lprod[0].NombreProducto;
                    lblPrecioProductoDestacado1.Text = lprod[0].Precio.ToString();
                }

                if (lprod.Count > 1)
                {
                    lblProductoDestacado2.Text = lprod[1].NombreProducto;
                    lblPrecioProductoDestacado2.Text = lprod[1].Precio.ToString();
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }

        private void lblPrecioProductoDestacado2_Click(object sender, EventArgs e)
        {

        }
    }
}
