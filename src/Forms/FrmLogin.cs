using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Newtonsoft.Json.Linq;
using System.Reflection;
using static System.Net.WebRequestMethods;
using System.Net.Mail;
using System.Globalization;
using pet4sitter.Clases;
using pet4sitter.Forms;
using System.Web;

namespace pet4sitter
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Introduce email")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
            this.lblLine.BackColor = Color.FromArgb(0, 200, 100);
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                txtMail.Text = "Introduce email";
                txtMail.ForeColor = Color.FromArgb(0, 200, 100);
            }
            this.lblLine.BackColor = Color.White;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Introduce contraseña")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
            this.lblLinePassword.BackColor = Color.FromArgb(0, 200, 100);
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.Text = "Introduce contraseña"; 
                txtPass.PasswordChar = '\0';
                txtPass.ForeColor = Color.FromArgb(0, 200, 100);
            }
            this.lblLinePassword.BackColor = Color.White;
        }

        //Hover for the label I forgot my password:
        private void lblForgPass_MouseEnter(object sender, EventArgs e)
        {
            // Establecer el estilo de subrayado cuando el cursor entra en el Label
            lblForgPass.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Underline);
        }

        private void lblForgPass_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el estilo normal cuando el cursor sale del Label
            lblForgPass.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);
        }


        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblForgPass_Click(object sender, EventArgs e)
        {
            // Mostrar el MessageBox
            DialogResult result = MessageBox.Show("¿Olvidaste tu contraseña?", "Recuperar Contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                string newPassword = Utiles.GenerateRandomPassword(10); // Genera una contraseña aleatoria de longitud 10
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword); // Cifra la contraseña con BCrypt
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    if (User.CompruebaUsuarioExistente(txtMail.Text))
                    {
                        User.ActualizarContraseña(txtMail.Text, hashedPassword);
                        // Crea el mensaje de correo electrónico con la nueva contraseña
                        string mensajeCorreo = $@"
                    <!DOCTYPE html>
                    <html lang='es'>
                    <head>
                        <meta charset='UTF-8'>
                        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                        <title>Recuperación de Contraseña</title>
                        <style>
                            body {{
                                font-family: Arial, sans-serif;
                                line-height: 1.6;
                                background-color: rgb(170, 217, 190);
                                margin: 0;
                                padding: 0;
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
                                background: rgb(170, 217, 190);
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
                            .button {{
                                background-color: rgb(170, 217, 190);
                                border: none;
                                color: white;
                                padding: 10px 20px;
                                text-align: center;
                                text-decoration: none;
                                display: inline-block;
                                font-size: 16px;
                                margin: 4px 2px;
                                cursor: pointer;
                                border-radius: 5px;
                            }}
                        </style>
                    </head>
                    <body>
                        <div class='header'>
                            <h1>Recuperación de Contraseña</h1>
                        </div>
                        <div class='container'>
                            <div class='content'>
                                <p class='message'>Hola,<br>Has solicitado recuperar tu contraseña. Tu nueva contraseña es: <strong>{newPassword}</strong></p>
                                <p class='message'>Si no solicitaste este cambio, por favor ignora este correo.</p>
                                <p class='message'>Saludos,<br>Equipo de Soporte</p>
                            </div>
                        </div>
                        <div class='footer'>
                            <p>&copy; 2024 Pet4Sitter</p>
                        </div>
                    </body>
                    </html>";

                        // Envía el correo electrónico al usuario
                        var mailService = new MailServices.MailPet4Sitter();
                        mailService.sendMailHtml("Recuperación de Contraseña", mensajeCorreo, txtMail.Text.ToString());
                        MessageBox.Show("Revisa tu bandeja de entrada, te hemos enviado tu nueva contraseña", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido verificar que el usuario con ese email existe. Revisa tu email o regístrate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    ConBD.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("¡No hay problema! Puedes recordarla más tarde.", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private async void btnIniciarSesionGoogle_Click(object sender, EventArgs e)
        {
            await GoogleAuthenticator.exchangeCode();
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                Data.CurrentUser = User.EncontrarUsuarioGoogle(Data.UserGoogle.IdGoogle);
                if (Data.CurrentUser.IdGoogle != null)
                {

                    ConBD.CerrarConexion();
                    FrmInicio frmInicio = new FrmInicio();
                    frmInicio.Show();
                    frmInicio.Activate();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario no está registrado con google, regístralo desde el formulario de registro.");
                }
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
            ConBD.CerrarConexion();
        }


        // Agrega el texto dado al registro en pantalla y a la consola de depuración
        public void output(string output)
        {
            //textBoxOutput.Text = textBoxOutput.Text + output + Environment.NewLine;
            Console.WriteLine(output);
        }


        private void btnContinueWGoogle_MouseHover(object sender, EventArgs e)
        {
            this.pictureBoxContinueGoogle.BackColor = Color.FromArgb(224, 238, 249);
        }

        private void btnContinueWGoogle_Leave(object sender, EventArgs e)
        {
            this.pictureBoxContinueGoogle.BackColor = Color.White;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario RegisterForm
            FrmRegister registerForm = new FrmRegister();

            this.Hide();
            // Mostrar el formulario RegisterForm
            registerForm.Show();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            ChangeThemeMode();
        }

        private void AplicarIdioma()
        {
            lblWelcomeLogin.Text = Resources.Recursos_Localizable.FrmLogin.lblWelcomeLogin_Text;
            lblMail.Text = Resources.Recursos_Localizable.FrmLogin.lblMail_Text;
            txtMail.Text = Resources.Recursos_Localizable.FrmLogin.txtMail_Text;
            txtPass.Text = Resources.Recursos_Localizable.FrmLogin.txtPass_Text;
            lblPass.Text = Resources.Recursos_Localizable.FrmLogin.lblPass_Text;
            btnLogin.Text = Resources.Recursos_Localizable.FrmLogin.btnLogin_Text;
            btnRegister.Text = Resources.Recursos_Localizable.FrmLogin.btnRegister_Text;
            lblForgPass.Text = Resources.Recursos_Localizable.FrmLogin.lblForgPass_Text;
            btnContinueWGoogle.Text = Resources.Recursos_Localizable.FrmLogin.btnContinueWGoogle_Text;
        }

        private void pictureBoxContinueGoogle_Click(object sender, EventArgs e)
        {
            btnIniciarSesionGoogle_Click(null, null);
        }

        private void ChangeThemeMode()
        {
            if (Data.DarkMode)
            {
                // Configurar el tema oscuro
                this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
                panel1.BackColor = Color.Black;
                this.BackColor = Color.DarkGreen;
                this.txtMail.BackColor = Color.DarkGreen;
                this.txtPass.BackColor = Color.DarkGreen;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                if (User.CompruebaUsuarioExistente(txtMail.Text))
                {
                    if (User.CompruebaCredencialesUsuario(txtMail.Text, txtPass.Text))
                    {
                        Data.CurrentUser = User.EncontrarUsuario(txtMail.Text);
                        ConBD.CerrarConexion();
                        FrmInicio frmInicio = new FrmInicio();
                        frmInicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Comprueba tus credenciales");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe, Regístrate", "Usuario no Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblReportarBug_Click(object sender, EventArgs e)
        {
            FrmReportarBug frm = new FrmReportarBug();

            this.Hide();
            frm.Show();
        }
    }
}
