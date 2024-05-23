using System;
using System.Globalization;
using System.Threading;

using pet4sitter.Resources.Recursos_Localizable;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void AplicarIdioma()
        {
            btnDesactivar.Text = Resources.Recursos_Localizable.FrmConf.btnDesactivar_Text;
            btnEliminar.Text = Resources.Recursos_Localizable.FrmConf.btnEliminar_Text;
            lblConfiguracionAvanzada.Text = Resources.Recursos_Localizable.FrmConf.lblConfiguracionAvanzada_Text;
            lblDesactivar.Text = Resources.Recursos_Localizable.FrmConf.lblDesactivar_Text;
            lblEliminar.Text = Resources.Recursos_Localizable.FrmConf.lblEliminar_Text;
            lblIdioma.Text = Resources.Recursos_Localizable.FrmConf.lblIdioma_Text;
            lblPrivacidad.Text = Resources.Recursos_Localizable.FrmConf.lblPrivacidad_Text;
            lblTema.Text = Resources.Recursos_Localizable.FrmConf.lblTema_Text;
            lbl2pasos.Text = Resources.Recursos_Localizable.FrmConf.lbl2pasos_Text;
        }


        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            cmbIdioma.Text = ConfiguracionIdioma.Cultura.DisplayName;
            cmbTema.SelectedIndex = Data.DarkMode ? 1 : 0;
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idioma = "";
            switch (cmbIdioma.Text)
            {
                case "Español":
                    {
                        idioma = "ES-ES";
                    }
                    break;

                case "Ingles":
                    {
                        idioma = "en-US";
                    }
                    break;
            }
            ConfiguracionIdioma.CambiarIdioma(new CultureInfo(idioma));
            AplicarIdioma();
        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTema.SelectedIndex == 0)
            {
                Data.DarkMode = false;
            }
            else
            {
                Data.DarkMode = true;
            }
        }
    }
}
