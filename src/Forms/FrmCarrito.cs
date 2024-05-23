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
            CargarProductosCarrito();
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
            frmED.Show();
        }

        private void btnEditarPago_Click(object sender, EventArgs e)
        {
            FrmEditarTarjeta frmET = new FrmEditarTarjeta();
            frmET.Show();
        }

        private async void CargarProductosCarrito()
        {
            if (ConBD.Conexion != null)
            {
                try
                {
                    string query = @"
                        SELECT p.id_product, p.name, p.price, p.quantity, p.description, p.image 
                        FROM delivery_products dp
                        JOIN products p ON dp.id_product = p.id_product
                        JOIN delivery d ON dp.id_delivery = d.id_delivery
                        WHERE d.id_receiver = @CurrentUserId";

                    using (MySqlCommand cmd = new MySqlCommand(query, ConBD.Conexion))
                    {
                        cmd.Parameters.AddWithValue("@CurrentUserId", Data.CurrentUser.IdUser);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable productos = new DataTable();
                        adapter.Fill(productos);

                        if (productos != null)
                        {
                            SuspendLayout(); // Suspender el diseño del formulario
                            fLPanelCarrito.SuspendLayout(); // Suspender el diseño del panel

                            bool nuevosProductos = false; // Bandera para saber si se agregaron nuevos productos

                            foreach (DataRow row in productos.Rows)
                            {
                                string productoId = row["id_product"].ToString();
                                if (!productosCargados.Contains(productoId))
                                {
                                    productosCargados.Add(productoId);
                                    nuevosProductos = true;

                                    ProductoEnCarrito producto = new ProductoEnCarrito();
                                    producto.Dock = DockStyle.Top;
                                    producto.BringToFront();
                                    producto.Nombre = row["name"].ToString();
                                    producto.Precio = Convert.ToDouble(row["price"]);
                                    producto.Cantidad = Convert.ToInt32(row["quantity"]);
                                    producto.Descripcion = row["description"].ToString();
                                    producto.Imagen = Utiles.ByteArrayToImage((byte[])row["image"]);
                                    fLPanelCarrito.Controls.Add(producto);
                                }
                            }

                            fLPanelCarrito.ResumeLayout(true); // Reanudar el diseño del panel
                            ResumeLayout(true); // Reanudar el diseño del formulario

                            if (nuevosProductos)
                            {
                                ScrollToBottom(); // Desplazar al fondo si hay nuevos productos
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
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
    }
}
