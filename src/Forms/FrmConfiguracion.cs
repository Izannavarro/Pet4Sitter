using System;
using System.Globalization;
using System.Threading;
using pet4sitter.Clases;
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
            btnEliminar.Text = Resources.Recursos_Localizable.FrmConf.btnEliminar_Text;
            lblConfiguracionAvanzada.Text = Resources.Recursos_Localizable.FrmConf.lblConfiguracionAvanzada_Text;
            lblEliminar.Text = Resources.Recursos_Localizable.FrmConf.lblEliminar_Text;
            lblIdioma.Text = Resources.Recursos_Localizable.FrmConf.lblIdioma_Text;
            lblPrivacidad.Text = Resources.Recursos_Localizable.FrmConf.lblPrivacidad_Text;
            lblTema.Text = Resources.Recursos_Localizable.FrmConf.lblTema_Text;
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

        private void ptbVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "¿Estás seguro que quieres eliminar tu cuenta? Todos los datos se borrarán y tendrás que volver a registrarte.",
        "Confirmar Eliminación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    );

            if (result == DialogResult.Yes)
            {
                if(ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    User.EliminarUsuarios((int)Data.CurrentUser.IdUser);
                    ConBD.CerrarConexion();
                }
                Data.CurrentUser = null;
                this.Dispose();
            }
        }
    }
}
