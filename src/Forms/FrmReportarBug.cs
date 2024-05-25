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
            CambiarModoOscuro();
        }

        private void CambiarModoOscuro()
        {
            if (Data.DarkMode)
            {
                this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
                this.BackColor = Color.DarkGreen;
                this.lblCorreoElectronicoUsuario.ForeColor = Color.White;
                this.lblDetallesDelBug.ForeColor = Color.White;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                if (User.EncontrarUsuario(txtMail.Text) != null)
                {
                    string userMail = txtMail.Text;
                    string date = DateTime.Now.ToString();
                    string messageBody = txtCuerpoMensaje.Text;

                    // HTML para el administrador
                    string adminMessage = $@"
            <!DOCTYPE html>
            <html lang='es'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Reporte de Bug</title>
                <link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        line-height: 1.6;
                        background-color: #f8f9fa;
                    }}
                    .container {{
                        width: 80%;
                        margin: auto;
                        overflow: hidden;
                        background: #fff;
                        padding: 20px;
                        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                    }}
                    .header, .footer {{
                        background: #343a40;
                        color: #fff;
                        padding: 10px 0;
                        text-align: center;
                    }}
                    .header h1, .footer p {{
                        margin: 0;
                    }}
                    .content {{
                        margin: 20px 0;
                    }}
                    .message {{
                        padding: 10px;
                        background: #f8d7da;
                        border: 1px solid #f5c6cb;
                        border-radius: 5px;
                    }}
                </style>
            </head>
            <body>
                <div class='header'>
                    <h1>Reporte de Bug</h1>
                </div>
                <div class='container'>
                    <div class='content'>
                        <p class='message'>El presunto usuario con correo: <strong>{userMail}</strong> a fecha de <strong>{date}</strong> reporta lo siguiente:</p>
                        <p>{messageBody}</p>
                    </div>
                </div>
                <div class='footer'>
                    <p>Gracias por tu reporte</p>
                </div>
            </body>
            </html>";

                    // HTML para el usuario
                    string userMessage = $@"
            <!DOCTYPE html>
            <html lang='es'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Confirmación de Reporte de Bug</title>
                <link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        line-height: 1.6;
                        background-color: #f8f9fa;
                    }}
                    .container {{
                        width: 80%;
                        margin: auto;
                        overflow: hidden;
                        background: #fff;
                        padding: 20px;
                        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                    }}
                    .header, .footer {{
                        background: #343a40;
                        color: #fff;
                        padding: 10px 0;
                        text-align: center;
                    }}
                    .header h1, .footer p {{
                        margin: 0;
                    }}
                    .content {{
                        margin: 20px 0;
                    }}
                    .message {{
                        padding: 10px;
                        background: #d4edda;
                        border: 1px solid #c3e6cb;
                        border-radius: 5px;
                    }}
                </style>
            </head>
            <body>
                <div class='header'>
                    <h1>Confirmación de Reporte de Bug</h1>
                </div>
                <div class='container'>
                    <div class='content'>
                        <p class='message'>Has mandado un bug a la aplicación Pet4Sitter el día <strong>{date}</strong>.</p>
                        <p>Contenido del correo:</p>
                        <p>El presunto usuario con correo: <strong>{userMail}</strong> reporta lo siguiente:</p>
                        <p>{messageBody}</p>
                    </div>
                </div>
                <div class='footer'>
                    <p>Gracias por tu reporte</p>
                </div>
            </body>
            </html>";

                    var mailService = new MailServices.MailPet4Sitter();
                    mailService.sendMailHtml("Reporte de Bug", adminMessage, "pirojodam@gmail.com");

                    var mailServiceCliente = new MailServices.MailPet4Sitter();
                    mailServiceCliente.sendMailHtml("Confirmación de Reporte de Bug", userMessage, userMail);

                    MessageBox.Show("Se ha enviado el bug a Pet4Sitter, si el bug recibido se verifica, serás recompensado y nos pondremos en contacto contigo.", "Enviar Reporte de Bug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido verificar que el usuario con ese email existe. Revisa tu email o regístrate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
