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
    public partial class FrmEditarTarjeta : Form
    {
        public FrmEditarTarjeta()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarTarjeta_Load(object sender, EventArgs e)
        {
            ModoOscuro();
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }
        void ModoOscuro()
        {
            if (Data.DarkMode)
            {
                this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
                this.BackColor = Color.DarkGreen;
            }
        }

        private void AplicarIdioma()
        {
            btnVolver.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.btnVolver_Text;
            lblConfiguracionAvanzada.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblConfiguracionAvanzada_Text;
            lblTitular.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblTitular_Text;
            lblNumero.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblNumero_Text;
            lblFecha.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblFecha_Text;
            lblCVC.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.lblCVC_Text;
            btnGuardar.Text = Resources.Recursos_Localizable.FrmEditarTarjeta.btnGuardar_Text;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Length == 16)
            {
                DateTime fechaIntroducida = dtpFecha.Value;
                if (fechaIntroducida > DateTime.Now)
                {
                    long numTarg = long.Parse(txtNumero.Text);
                    string titular = txtTitular.Text;
                    int cvc = Convert.ToInt32(txtCVC.Text);
                    DateTime fecha = fechaIntroducida;

                    Tarjeta t = new Tarjeta(numTarg,titular,fecha,cvc);
                    Data.CurrentTarjeta = t;
                    MessageBox.Show("Tarjeta guardada correctamente");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("La fecha introducida es errónea o está caducada!");
                }
            }
            else
            {
                MessageBox.Show("Los números de la Tarjeta son Incorrectos!");
            }
        }
    }
}
