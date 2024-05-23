using MySql.Data.MySqlClient;
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
    public partial class FrmCarrito : Form
    {
        private List<string> productosCargados = new List<string>();

        public FrmCarrito()
        {
            InitializeComponent();
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            CargarProductos();
            lblLocalizacion.Text = Data.CurrentUser.Location;
        }

        private void AplicarIdioma()
        {
            lblDescripcionLocalizacion.Text = Resources.Recursos_Localizable.FrmCarrito.lblDescripcionLocalizacion_Text;
            btnEliminar.Text = Resources.Recursos_Localizable.FrmCarrito.btnEliminar_Text;
            lblSubtotal.Text = Resources.Recursos_Localizable.FrmCarrito.lblSubtotal_Text;
            btnEditarPago.Text = Resources.Recursos_Localizable.FrmCarrito.btnEditarPago_Text;
            btnEditar.Text = Resources.Recursos_Localizable.FrmCarrito.btnEditar_Text;
            lblResumen.Text = Resources.Recursos_Localizable.FrmCarrito.lblResumen_Text;
            btnVolverPago.Text = Resources.Recursos_Localizable.FrmCarrito.btnVolverPago_Text;
            lblDescripcionTarjeta.Text = Resources.Recursos_Localizable.FrmCarrito.lblDescripcionTarjeta_Text;
            lblMetodo.Text = Resources.Recursos_Localizable.FrmCarrito.lblMetodo_Text;
            btnRealizar.Text = Resources.Recursos_Localizable.FrmCarrito.btnRealizar_Text;
        }

        private void FrmCarrito_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarDireccion frmED = new FrmEditarDireccion();
            frmED.ShowDialog();
        }

        private void btnEditarPago_Click(object sender, EventArgs e)
        {
            FrmEditarTarjeta frmET = new FrmEditarTarjeta();
            frmET.ShowDialog();
        }

        private void CargarProductos()
        {
            if(Carrito.Productos.Count > 0)
            {
                foreach(Producto p in Carrito.Productos)
                {
                    ProductoEnCarrito pec = new ProductoEnCarrito();
                    pec.Nombre = p.NombreProducto;
                    pec.Precio = p.Precio;
                    pec.Descripcion = p.Descripcion;
                    pec.Cantidad = p.Cantidad;
                    pec.Imagen = p.UrlImagen;
                    pec.Id = (int)p.Id;
                    fLPanelCarrito.Controls.Add(pec);
                }
            }
            else
            {
                lblInfo.Visible = true;
                lblInfo.Text = "NO HAY PRODUCTOS EXISTENTES!";
            }
        }

        private void ScrollToBottom()
        {
            if (fLPanelCarrito.Controls.Count > 0)
            {
                var lastControl = fLPanelCarrito.Controls[fLPanelCarrito.Controls.Count - 1];
                fLPanelCarrito.ScrollControlIntoView(lastControl);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el carrito?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Carrito.Productos.Clear();
                this.Close();
                this.Dispose();
            }
        }
    }
}
