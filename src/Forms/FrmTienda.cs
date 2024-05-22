using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class FrmTienda : Form
    {
        public FrmTienda()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
        }

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            btnAñadir.Text = Resources.Recursos_Localizable.FrmTienda.btnAñadir_Text;
        }

        private void LimpiarTablaProductos()
        {
            dgvProductos.DataSource = null;
            // Limpia las filas
            dgvProductos.Rows.Clear();

            // Asigna el nuevo DataSource
            dgvProductos.DataSource = Producto.CantidadProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex]; 
            lblNombre.Text = fila.Cells[1].Value.ToString();
            lblPrecio.Text = fila.Cells[2].Value.ToString();
            txtDescripcion.Text = fila.Cells[4].Value.ToString();
            ptbImagenProducto.Image = (Image)fila.Cells[5].Value;
        }
    }
}
