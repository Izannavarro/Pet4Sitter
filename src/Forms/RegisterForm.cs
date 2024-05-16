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
using static Google.Apis.Requests.BatchRequest;
using System.Runtime.Remoting.Contexts;

namespace piTest
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
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
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                txtMail.Text = "Introduce email";
                txtMail.ForeColor = Color.Gray; // Cambiar el color del texto al color del marcador de posición
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Introduce contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.Text = "Introduce contraseña";
                txtPass.ForeColor = Color.Gray; // Cambiar el color del texto al color del marcador de posición
            }
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
            }
            else
            {
                MessageBox.Show("¡No hay problema! Puedes recuérdala más tarde.", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIniciarSesionGoogle_Click(object sender, EventArgs e)
        {
            GoogleAuthenticator.exchangeCode(this);
        }

        
        // Agrega el texto dado al registro en pantalla y a la consola de depuración
        public void output(string output)
        {
            textBoxOutput.Text = textBoxOutput.Text + output + Environment.NewLine;
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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.Show();
        }
    }
}
