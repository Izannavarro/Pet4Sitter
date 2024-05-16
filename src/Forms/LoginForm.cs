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
using piTest.Clases;

namespace piTest
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
                txtPass.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
            this.lblLinePassword.BackColor = Color.FromArgb(0, 200, 100);
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.Text = "Introduce contraseña";
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
                // Código para recuperar la contraseña aquí
                MessageBox.Show("Se ha enviado un enlace de recuperación a tu correo electrónico.", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var mailService = new MailServices.ForgotPasswordMail();
                mailService.sendMail("Recuperar Contraseña Proyecto Integrado", "Hola esto es un test desde mi app para el grupo del proyecto integrado\nTU nueva contraseña es xxxxxxxxxxxxxxxxx", txtMail.Text.ToString());
            }
            else
            {
                MessageBox.Show("¡No hay problema! Puedes recuérdala más tarde.", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnIniciarSesionGoogle_Click(object sender, EventArgs e)
        {
            await GoogleAuthenticator.exchangeCode();
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
            RegisterForm registerForm = new RegisterForm();

            // Mostrar el formulario RegisterForm
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (LoginForm) si lo deseas
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CultureInfo systemCulture = CultureInfo.CurrentCulture;
            string idiomaSistema = systemCulture.Name;
            ChangeThemeMode();
        }

        private void pictureBoxContinueGoogle_Click(object sender, EventArgs e)
        {
            btnIniciarSesionGoogle_Click(null, null);
        }

        private void ChangeThemeMode()
        {
            if (Data.IsDarkModeEnabled())
            {
                // Configurar el tema oscuro
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
                    if(User.CompruebaCredencialesUsuario(txtMail.Text,txtPass.Text))
                    {
                        MessageBox.Show("Si");
                        Dashboard d = new Dashboard(null);
                        d.Show();
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
    }
}
