using Google.Apis.Oauth2.v2.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace pet4sitter
{
    public partial class Dashboard : Form
    {
        public Dashboard(string gUserInfo)
        {
            InitializeComponent();

            // Procesar la información del usuario y establecer las propiedades del formulario
            JObject userInfoObject = JObject.Parse(gUserInfo);

            // Establecer el texto en el TextBox
            //foreach (var property in userInfoObject.Properties())
            //{
            //    string label = $"{property.Name}: {property.Value}";
            //    textBox1.Text = textBox1.Text + label + Environment.NewLine;
            //}

            lblNameCharged.Text = userInfoObject["name"].ToString();
            lblLangCharged.Text = userInfoObject["locale"].ToString();

            // Obtener la URL de la imagen del perfil del usuario y establecerla en el PictureBox
            string pictureUrl = userInfoObject["picture"].ToString();
            pictureBox1.Load(pictureUrl);

            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //DB.SelectAllFromUsers();
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblName.Text = Resources.Recursos_Localizable.Dashboard.lblNombre;
            lblLang.Text = Resources.Recursos_Localizable.Dashboard.lblLang;
        }
    }
}
