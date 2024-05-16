using System;
using System.Globalization;
using System.Threading;
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
    public partial class FrmChat : Form
    {
        public FrmChat()
        {
            InitializeComponent();
        }

        private void FrmChat_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblNombre1.Text = Resources.Recursos_Localizable.FrmChat.lblNombre1_Text;
            lblNombre2.Text = Resources.Recursos_Localizable.FrmChat.lblNombre2_Text;
            lblNombre3.Text = Resources.Recursos_Localizable.FrmChat.lblNombre3_Text;
            lblNombre4.Text = Resources.Recursos_Localizable.FrmChat.lblNombre4_Text;
            lblNombre5.Text = Resources.Recursos_Localizable.FrmChat.lblNombre5_Text;
            btnSiguiente.Text = Resources.Recursos_Localizable.FrmChat.btnSiguiente_Text;
            btnAnterior.Text = Resources.Recursos_Localizable.FrmChat.btnAnterior_Text;
            btnOpciones.Text = Resources.Recursos_Localizable.FrmChat.btnOpciones_Text;
            btnEnviar.Text = Resources.Recursos_Localizable.FrmChat.btnEnviar_Text;
        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show(); // Muestra el formulario FrmConfiguracion
        }
    }
}
