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
using pet4sitter.Clases;
using Mysqlx;
using System.Globalization;

namespace pet4sitter
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
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

        private async void btnIniciarSesionGoogle_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                await GoogleAuthenticator.exchangeCode();
                if (Data.UserGoogle.IdGoogle != null && !User.CompruebaUsuarioConGoogle(Data.UserGoogle.IdGoogle))
                {
                    this.Activate();
                    txtNombre.Text = Data.UserGoogle.Name;
                    MessageBox.Show("Es la primera vez que te registras, completa tus datos, solo será una vez", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario vinculado a esa cuenta de google");
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }


        // Agrega el texto dado al registro en pantalla y a la consola de depuración
        public void output(string output)
        {
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
            FrmLogin l = new FrmLogin();
            this.Dispose();
            l.Show();
        }

        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            if (Utiles.CheckDNI(txtDni.Text))
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    if (!User.CompruebaUsuarioExistente(txtMail.Text))
                    {
                        // Validar la dirección ingresada
                        var coordenadas = await GeoLocalizacion.ObtenerCoordenadasAsync(txtDireccion.Text);

                        if (coordenadas.Latitude.HasValue && coordenadas.Longitude.HasValue)
                        {
                            // Pregunta al usuario si desea validar la ubicación
                            if (MessageBox.Show(
                                "Deseas validar la ubicación?",
                                "Confirmar Ubicación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            ) == DialogResult.Yes)
                            {
                                // Abre el navegador web predeterminado con Google Maps
                                System.Diagnostics.Process.Start($"https://maps.google.com/?q={coordenadas.Latitude.ToString().Replace(',', '.')},{coordenadas.Longitude.ToString().Replace(',', '.')}");

                                // Muestra otro MessageBox para solicitar la confirmación del usuario
                                if (MessageBox.Show(
                                    "¿La dirección es correcta?",
                                    "Confirmar Dirección",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                ) == DialogResult.Yes)
                                {
                                    // Si el usuario confirma la dirección, procede con el registro
                                    // del usuario aquí
                                    User u = null;
                                    if (Data.UserGoogle != null)
                                    {
                                        u = new User(null, Data.UserGoogle.IdGoogle, txtNombre.Text, txtApellido.Text, txtMail.Text, txtDni.Text, txtPass.Text, null, txtDireccion.Text, null, false, null, null, coordenadas.Latitude.Value, coordenadas.Longitude.Value);
                                    }
                                    else
                                    {
                                        u = new User(null, null, txtNombre.Text, txtApellido.Text, txtMail.Text, txtDni.Text, txtPass.Text, null, txtDireccion.Text, null, false, null, null, coordenadas.Latitude.Value, coordenadas.Longitude.Value);
                                    }
                                    User.RegistrarUsuario(u);
                                    MessageBox.Show("Usuario: " + u.Name + " Registrado con éxito!");
                                }
                                else
                                {
                                    // Si el usuario no confirma la dirección, puedes realizar alguna
                                    // acción adicional aquí, como mostrar un mensaje o volver a solicitar
                                    // la dirección.
                                    MessageBox.Show("Por favor, revise la dirección e intente nuevamente.", "Dirección Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                // Si el usuario no desea validar la ubicación, procede con el registro
                                // del usuario directamente aquí
                                User u = null;
                                if (Data.UserGoogle != null)
                                {
                                    u = new User(null, Data.UserGoogle.IdGoogle, txtNombre.Text, txtApellido.Text, txtMail.Text, txtDni.Text, txtPass.Text, null, txtDireccion.Text, null, false, null, null, coordenadas.Latitude.Value, coordenadas.Longitude.Value);
                                }
                                else
                                {
                                    u = new User(null, null, txtNombre.Text, txtApellido.Text, txtMail.Text, txtDni.Text, txtPass.Text, null, txtDireccion.Text, null, false, null, null, coordenadas.Latitude.Value, coordenadas.Longitude.Value);
                                }
                                User.RegistrarUsuario(u);
                                MessageBox.Show("Usuario: " + u.Name + " Registrado con éxito!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La dirección ingresada no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con ese email", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    ConBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No existe conexión a la Base de datos");
                }//Comprueba si la bd está disponible
            }
            else
            {
                MessageBox.Show("El DNI introducido es Erróneo,Introdúcelo de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Text = "";
                txtDni.Focus();
            }
        }



        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray; // Cambiar el color del texto al color del marcador de posición
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "Nombre")
            {
                txtNombre.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }

        private void FrmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            AplicarModoOscuro();
        }
        private void AplicarModoOscuro()
        {
            this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
            lblWelcomeLogin.ForeColor = Color.Black;
            this.BackColor = Color.DarkGreen;
            txtNombre.BackColor = Color.DarkGreen;
            txtApellido.BackColor = Color.DarkGreen;
            txtDni.BackColor = Color.DarkGreen;
            txtMail.BackColor = Color.DarkGreen;
            txtPass.BackColor = Color.DarkGreen;
            txtDireccion.BackColor = Color.DarkGreen;
        }
        private void AplicarIdioma()
        {
            lblWelcomeLogin.Text = Resources.Recursos_Localizable.FrmRegister.lblWelcomeLogin_Text;
            lblMail.Text = Resources.Recursos_Localizable.FrmRegister.lblMail_Text;
            txtMail.Text = Resources.Recursos_Localizable.FrmRegister.txtMail_Text;
            txtPass.Text = Resources.Recursos_Localizable.FrmRegister.txtPass_Text;
            lblPass.Text = Resources.Recursos_Localizable.FrmRegister.lblPass_Text;
            btnLogin.Text = Resources.Recursos_Localizable.FrmRegister.btnLogin_Text;
            btnContinueWGoogle.Text = Resources.Recursos_Localizable.FrmRegister.btnContinueWGoogle_Text;
            lblNombre.Text = Resources.Recursos_Localizable.FrmRegister.lblNombre_Text;
            txtNombre.Text = Resources.Recursos_Localizable.FrmRegister.txtNombre_Text;
            lblApellido.Text = Resources.Recursos_Localizable.FrmRegister.lblApellido_Text;
            txtApellido.Text = Resources.Recursos_Localizable.FrmRegister.txtApellido_Text;
            lblDni.Text = Resources.Recursos_Localizable.FrmRegister.lblDni_Text;
            txtDni.Text = Resources.Recursos_Localizable.FrmRegister.txtDni_Text;
            lblDireccion.Text = Resources.Recursos_Localizable.FrmRegister.lblDireccion_Text;
            txtDireccion.Text = Resources.Recursos_Localizable.FrmRegister.txtDireccion_Text;
            btnRegistro.Text = Resources.Recursos_Localizable.FrmRegister.btnRegistro_Text;
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido:")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.Text = "Apellido:";
                txtApellido.ForeColor = Color.Gray; // Cambiar el color del texto al color del marcador de posición
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI:")
            {
                txtDni.Text = "";
                txtDni.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                txtDni.Text = "DNI:";
                txtDni.ForeColor = Color.Gray; // Cambiar el color del texto al color del marcador de posición
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Introduce dirección")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                txtDireccion.Text = "Introduce dirección";
                txtDireccion.ForeColor = Color.Gray; // Cambiar el color del texto al color del marcador de posición
            }
        }
    }
}
