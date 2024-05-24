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
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            if (Data.CurrentUser.Image != null)
            {
                pcbImagen.Image = Utiles.ByteArrayToImage(Data.CurrentUser.Image);
            }
            lblNombre.Text = Data.CurrentUser.Name.ToUpper();
            lblLocalizacion.Text = Data.CurrentUser.Location;
            CompruebaSitter();
        }

        private void CompruebaSitter()
        {
            if (Data.CurrentUser.Sitter == true)
            {
                lblPrecio.Text = Data.CurrentUser.Precio.ToString() + "€/Día";
                btnDarAlta.Visible = false;
                btnDarseBaja.Visible = true;
            }
            else
            {
                btnDarAlta.Visible = true;
                btnDarseBaja.Visible = false;
                lblPrecio.Text = "Este Usuario NO es Cuidador";
            }
        }

        private void AplicarIdioma()
        {
            lblUltimaCompra.Text = Resources.Recursos_Localizable.FrmPerfil.lblUltimaCompra_Text;
            btnEditarPerfil.Text = Resources.Recursos_Localizable.FrmPerfil.btnEditarPerfil_Text;
            btnDarAlta.Text = Resources.Recursos_Localizable.FrmPerfil.btnDarAlta_Text;
        }

        private void FrmPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            FrmEditarPerfil frm = new FrmEditarPerfil();
            frm.ShowDialog();
            if (Data.CurrentUser.Image != null)
            {
                pcbImagen.Image = Utiles.ByteArrayToImage(Data.CurrentUser.Image);
            }
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            FrmDarseDeAlta frm = new FrmDarseDeAlta();
            frm.ShowDialog();
            CompruebaSitter();

        }

        private void btnDarseBaja_Click(object sender, EventArgs e)
        {
            User u = new User(Data.CurrentUser.IdUser, Data.CurrentUser.IdGoogle, Data.CurrentUser.Name, Data.CurrentUser.Surname, Data.CurrentUser.Email, Data.CurrentUser.Dni, Data.CurrentUser.Password, Data.CurrentUser.Precio, Data.CurrentUser.Location, Data.CurrentUser.Premium, false, Data.CurrentUser.Admin, Data.CurrentUser.Image, Data.CurrentUser.Latitud, Data.CurrentUser.Longitud);
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                User.ActualizarUsuario(u);
                ConBD.CerrarConexion();
                MessageBox.Show("Usuario: "+ Data.CurrentUser.Name+" dado de baja como cuidador con éxito!");
                this.Hide();
                btnDarAlta.Visible = true;
                btnDarseBaja.Visible = false;
                this.Show();
                lblPrecio.Text = "Este Usuario NO es Cuidador";

            }
            else
            {
                MessageBox.Show("No te has podido dar de baja!");
            }
        }
    }
}
