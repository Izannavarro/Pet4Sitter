using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pet4sitter.Clases;

namespace pet4sitter
{
    public partial class FrmNoticias : Form
    {
        List<Noticia> lNoticias = new List<Noticia>();
        public FrmNoticias()
        {
            InitializeComponent();
        }

        private async void FrmNoticias_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            try
            {
                await CargarNoticiasAsync();
                // Aquí puedes hacer algo con lNoticias, como actualizar la UI
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al cargar noticias: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion frm = new FrmConfiguracion(); // Crea una nueva instancia de FrmConfiguracion
            frm.Show();
        }

        private async Task CargarNoticiasAsync()
        {
            NewsFetcher nFetcher = new NewsFetcher(Data.tokenNoticias);
            lNoticias = await nFetcher.FetchAnimalNewsList();
            if (lNoticias.Count > 0)
            {
                lblTituloNoticia1.Text = lNoticias[0].Titulo;
                pcbNoticia1.Load(lNoticias[0].UrlImagen);
                lblCuerpoNoticia.Text = lNoticias[0].Descripcion;
            }

            if(lNoticias.Count > 1)
            {

            }

            if (lNoticias.Count > 2)
            {

            }
        }

        private void AplicarIdioma()
        {
            btnAnterior.Text = Resources.Recursos_Localizable.FrmNoticias.btnAnterior_Text;
            btnSiguiente.Text = Resources.Recursos_Localizable.FrmNoticias.btnSiguiente_Text;
        }

        private void FrmNoticias_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
