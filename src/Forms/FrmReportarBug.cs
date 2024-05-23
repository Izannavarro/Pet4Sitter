using pet4sitter.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter.Forms
{
    public partial class FrmReportarBug : Form
    {
        public FrmReportarBug()
        {
            InitializeComponent();
        }

        private void FrmReportarBug_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                if(User.EncontrarUsuario(txtMail.Text) != null)
                {

                    var mailService = new MailServices.MailPet4Sitter();
                    mailService.sendMail("BUG", $"El presunto usuario con mail : {txtMail.Text} a fecha de {DateTime.Now} reporta lo siguiente: {txtCuerpoMensaje.Text}", "pirojodam@gmail.com");
                    var mailServiceCliente = new MailServices.MailPet4Sitter();
                    mailServiceCliente.sendMail("BUG", $"Has mandado un bug a la app de pet4sitter el dia {DateTime.Now} Contenido del mail: \r\nEl presunto usuario con mail : {txtMail.Text} reporta lo siguiente: {txtCuerpoMensaje.Text}", txtMail.Text);
                    MessageBox.Show("Se ha enviado el bug a pet4sitter, si el bug recibido se verifica serás recompensado y nos pondremos en contacto contigo", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido verificar que el usuario con ese email existe revisa tu email o regístrate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ConBD.CerrarConexion();
            }
        }

        private void btnVolverALogin_Click(object sender, EventArgs e)
        {
            FrmLogin l = new FrmLogin();
            this.Dispose();
            l.Show();
        }
    }
}
