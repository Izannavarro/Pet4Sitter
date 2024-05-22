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
    public partial class FrmDarseDeAlta : Form
    {
        public FrmDarseDeAlta()
        {
            InitializeComponent();
        }

        private void FrmDarseDeAlta_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            
        }

        private void AplicarIdioma()
        {
            lblPrecioDia.Text = Resources.Recursos_Localizable.FrmAlta.lblPrecioDia_Text;
            btnGuardar.Text = Resources.Recursos_Localizable.FrmAlta.btnGuardar_Text;
            btnVolver.Text = Resources.Recursos_Localizable.FrmAlta.btnVolver_Text;
            lblDarseAlta.Text = Resources.Recursos_Localizable.FrmAlta.lblTittle_Text;
            chkTerminos.Text = Resources.Recursos_Localizable.FrmAlta.chkPolitica;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(chkTerminos.Checked )
            {
                if(!Data.CurrentUser.Sitter == true)
                {
                    double precio = double.Parse(nudPrecio.Value.ToString());
                    User u = new User(Data.CurrentUser.IdUser, Data.CurrentUser.IdGoogle, Data.CurrentUser.Name, Data.CurrentUser.Surname, Data.CurrentUser.Email, Data.CurrentUser.Dni, Data.CurrentUser.Password,precio, Data.CurrentUser.Location, Data.CurrentUser.Premium, true, Data.CurrentUser.Admin, Data.CurrentUser.Image, Data.CurrentUser.Latitud, Data.CurrentUser.Longitud);
                    if (ConBD.Conexion != null)
                    {
                        ConBD.AbrirConexion();
                        User.ActivarCuidador(u);
                        ConBD.CerrarConexion();
                    }
                    MessageBox.Show("Has sido dado de Alta como Cuidador!");
                }
                else
                {
                    MessageBox.Show("Ya estás dado de Alta como Cuidador!");
                }
            }
            else
            {
                MessageBox.Show("Tienes que aceptar nuestras políticas de privacidad!");
            }
        }
    }
}
