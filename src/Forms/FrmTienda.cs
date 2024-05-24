using Org.BouncyCastle.Asn1.Ocsp;
using pet4sitter.Clases;
using pet4sitter.UserControls;
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
        bool carritoActivo = false;
        int cantProdList;
        public FrmTienda()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
        }

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            cantProdList = Carrito.Productos.Count;
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                LimpiarTablaProductos();
                ConBD.CerrarConexion();
            }
            btnAñadir.Enabled = false;
            if(dgvProductos.Rows.Count > 0)
            {
                SeleccionarPrimerProducto();
            }
            
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
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                lblId.Text = fila.Cells[0].Value.ToString();
                lblNombre.Text = fila.Cells[1].Value.ToString().ToUpper();
                lblPrecio.Text = fila.Cells[3].Value.ToString()+"€";
                txtDescripcion.Text = fila.Cells[4].Value.ToString();
                lblCantidad.Text = fila.Cells[2].Value.ToString();
                ptbImagenProducto.Image = (Image)fila.Cells[5].Value;
                btnAñadir.Enabled = true;
            }
        }

        private void SeleccionarPrimerProducto()
        {
                DataGridViewRow fila = dgvProductos.Rows[0];
                lblId.Text = fila.Cells[0].Value.ToString();
                lblNombre.Text = fila.Cells[1].Value.ToString().ToUpper();
                lblPrecio.Text = fila.Cells[3].Value.ToString() + "€";
                txtDescripcion.Text = fila.Cells[4].Value.ToString();
                lblCantidad.Text = fila.Cells[2].Value.ToString();
                ptbImagenProducto.Image = (Image)fila.Cells[5].Value;
                btnAñadir.Enabled = true;
        }

        private void ptbBusqueda_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                if (txtBusqueda.Text != "")
                {
                    dgvProductos.DataSource = Producto.EncontrarNombreProducto(txtBusqueda.Text.ToUpper());
                    ConBD.CerrarConexion();
                    if (dgvProductos.RowCount == 0)
                    {
                        MessageBox.Show("NO SE ENCONTRARON PRODUCTOS, VUELVA A BUSCAR!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBusqueda.Text = "";
                        txtBusqueda.Focus();
                        ConBD.AbrirConexion();
                        LimpiarTablaProductos();
                    }
                }
                else
                {
                    LimpiarTablaProductos();
                }
                ConBD.CerrarConexion();
            }
        }

        private void btnFlechaArriba_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                dgvProductos.DataSource = Producto.ProductosMayorMenor();
                ConBD.CerrarConexion();

                if (dgvProductos.RowCount == 0)
                {
                    ConBD.AbrirConexion();
                    MessageBox.Show("NO DISPONEMOS DE PRODUCTOS ACTUALMENTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarTablaProductos();
                    ConBD.CerrarConexion();
                }
            }
        }

        private void btnFlechaAbajo_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                dgvProductos.DataSource = Producto.ProductosMenorMayor();
                ConBD.CerrarConexion();

                if (dgvProductos.RowCount == 0)
                {
                    ConBD.AbrirConexion();
                    MessageBox.Show("NO DISPONEMOS DE PRODUCTOS ACTUALMENTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarTablaProductos();
                    ConBD.CerrarConexion();
                }
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            string nombre = lblNombre.Text;
            int canti = 1;
            double precio = Convert.ToDouble(lblPrecio.Text.ToString().Replace('€', ' '));
            string descrip = txtDescripcion.Text;
            Image img = ptbImagenProducto.Image;

            Producto p = new Producto(id, nombre, canti, precio, descrip, img);

                    int indiceProd = Carrito.IndiceProducto((int)p.Id);
                    if (indiceProd != -1)
                    {
                        Carrito.Productos[indiceProd].Cantidad += p.Cantidad;
                        MessageBox.Show("ACUMULADO PRODUCTO REPETIDO!");
                        CargarProductos();
                    }
                    else
                    {
                        Carrito.Productos.Add(p);
                        MessageBox.Show("PRODUCTO AÑADIDO");
                    }
            cantProdList = Carrito.Productos.Count;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                if (txtBusqueda.Text != "")
                {
                    dgvProductos.DataSource = Producto.EncontrarNombreProducto(txtBusqueda.Text.ToUpper());
                    ConBD.CerrarConexion();
                }
                else
                {
                    LimpiarTablaProductos();
                    ConBD.CerrarConexion();
                }
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void ptbCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.ShowDialog();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.ShowDialog();
        }

        private void btnVerCarrito_Click(object sender, EventArgs e)
        {
            if (!flpCarrito.Visible)
            {
                flpCarrito.Visible = true;
                CargarProductos();
                if (Carrito.Productos.Count == 0)
                {
                    lblInfo.Visible = true;
                    lblInfo.BringToFront();
                }
            }
            else
            {
                flpCarrito.Visible = false;
                lblInfo.Visible = false;
            } 
        }
        private void CargarProductos()
        {
            flpCarrito.Controls.Clear();
            if (Carrito.Productos.Count > 0)
            {
                foreach (Producto p in Carrito.Productos)
                {
                    ProductoEnCarrito pec = new ProductoEnCarrito();
                    pec.Dock = DockStyle.Top;
                    pec.BringToFront();
                    pec.Nombre = p.NombreProducto;
                    pec.Precio = p.Precio;
                    pec.Descripcion = p.Descripcion;
                    pec.Id = (int)p.Id;
                    pec.Cantidad = p.Cantidad;
                    pec.Imagen = p.UrlImagen;
                    flpCarrito.Controls.Add(pec);
                }
            }
            else
            {
                flpCarrito.Controls.Clear();
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (Carrito.Productos.Count != cantProdList)
            {
                CargarProductos();
            }
            if (Carrito.Productos.Count == 0)
            {
                if (flpCarrito.Visible == true)
                {
                    lblInfo.Visible = true;
                }
                else
                {
                    lblInfo.Visible = false;
                }
            }
        }
    }
}
