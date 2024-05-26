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
            pcbGifCarga.Visible = true;
            pcbGifCarga.BringToFront();
            AplicarModoOscuro();
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            CompruebaPremium();
            AplicarIdioma();
            pcbGifCarga.Visible = false;
        }

        private void AplicarIdioma()
        {
            lblFuncPre.Text = Resources.Recursos_Localizable.FrmNoticias.lblFuncPre;
            lblTituloNoticias.Text = Resources.Recursos_Localizable.FrmNoticias.lblTituloNoticias;
            lblInfoPulsar.Text = Resources.Recursos_Localizable.FrmNoticias.lblInfoPulsar;
        }

        private void AplicarModoOscuro()
        {
            if (Data.DarkMode)
            {
                this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
                this.BackColor = Color.DarkGreen;
                lblTituloNoticias.ForeColor = Color.White;
                lblInfoPulsar.ForeColor = Color.White;
            }
        }

        private async void CompruebaPremium()
        {
            if ((bool)Data.CurrentUser.Premium)
            {
                try
                {
                    await CargarNoticiasAsync();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine($"Error al cargar noticias: {ex.Message}");
                }
            }
            else
            {
                pnlPremium.Visible = true;
                pcbGifCarga.Visible = false;
                lblInfoPulsar.Visible = false;
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
            // Muestra el GIF de carga
            pcbGifCarga.Visible = true;

            try
            {
                NewsFetcher nFetcher = new NewsFetcher(Data.tokenNoticias);
                lNoticias = await nFetcher.FetchAnimalNewsList();

                if (lNoticias.Count > 0)
                {
                    Random rnd = new Random();
                    List<int> indicesSeleccionados = new List<int>();

                    // Función auxiliar para obtener un índice único
                    int ObtenerIndiceUnico(int max)
                    {
                        int indice;
                        do
                        {
                            indice = rnd.Next(max);
                        } while (indicesSeleccionados.Contains(indice));
                        indicesSeleccionados.Add(indice);
                        return indice;
                    }

                    // Función para asignar el evento Click
                    void AsignarEventoClick(Label label, string url)
                    {
                        label.Click += (sender, e) => System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true
                        });
                        label.Cursor = Cursors.Hand; // Cambia el cursor a mano para indicar que es un enlace
                    }

                    // Seleccionamos hasta 3 noticias aleatorias
                    if (lNoticias.Count > 0)
                    {
                        int indice = ObtenerIndiceUnico(lNoticias.Count);
                        lblTituloNoticia1.Text = lNoticias[indice].Titulo;
                        lblCuerpoNoticia.Text = lNoticias[indice].Descripcion;
                        AsignarEventoClick(lblTituloNoticia1, lNoticias[indice].Url);

                        // Validar la URL de la imagen antes de cargarla
                        if (!string.IsNullOrEmpty(lNoticias[indice].UrlImagen))
                        {
                            try
                            {
                                pcbNoticia1.Load(lNoticias[indice].UrlImagen);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error al cargar la imagen: {ex.Message}");
                                // Asignar una imagen de marcador de posición o mostrar un mensaje de error
                                pcbNoticia1.Image = Properties.Resources.lgo; // Ejemplo de imagen de marcador de posición
                                                                              // También puedes mostrar un mensaje de error
                            }
                        }
                        else
                        {
                            // Asignar una imagen de marcador de posición o mostrar un mensaje de error si la URL de la imagen es nula o vacía
                            pcbNoticia1.Image = Properties.Resources.lgo; // Ejemplo de imagen de marcador de posición
                                                                          // También puedes mostrar un mensaje de error
                        }
                    }

                    if (lNoticias.Count > 1)
                    {
                        int indice = ObtenerIndiceUnico(lNoticias.Count);
                        lblTituloNoticia2.Text = lNoticias[indice].Titulo;
                        lblCuerpoNoticia2.Text = lNoticias[indice].Descripcion;
                        AsignarEventoClick(lblTituloNoticia2, lNoticias[indice].Url);
                        // Validar la URL de la imagen antes de cargarla en pcbNoticia2
                        if (!string.IsNullOrEmpty(lNoticias[indice].UrlImagen))
                        {
                            try
                            {
                                pcbNoticia2.Load(lNoticias[indice].UrlImagen);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error al cargar la imagen para Noticia 2: {ex.Message}");
                                // Asignar una imagen de marcador de posición o mostrar un mensaje de error
                                pcbNoticia2.Image = Properties.Resources.lgo; // Ejemplo de imagen de marcador de posición
                            }
                        }
                        else
                        {
                            // Asignar una imagen de marcador de posición o mostrar un mensaje de error si la URL de la imagen es nula o vacía
                            pcbNoticia2.Image = Properties.Resources.lgo; // Ejemplo de imagen de marcador de posición
                        }
                    }

                    // Para Noticia 3
                    if (lNoticias.Count > 2)
                    {
                        int indice = ObtenerIndiceUnico(lNoticias.Count);
                        lblTituloNoticia3.Text = lNoticias[indice].Titulo;
                        lblCuerpoNoticia3.Text = lNoticias[indice].Descripcion;
                        AsignarEventoClick(lblTituloNoticia3, lNoticias[indice].Url);

                        // Validar la URL de la imagen antes de cargarla en pcbNoticia3
                        if (!string.IsNullOrEmpty(lNoticias[indice].UrlImagen))
                        {
                            try
                            {
                                pcbNoticia3.Load(lNoticias[indice].UrlImagen);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error al cargar la imagen para Noticia 3: {ex.Message}");
                                // Asignar una imagen de marcador de posición o mostrar un mensaje de error
                                pcbNoticia3.Image = Properties.Resources.lgo; // Ejemplo de imagen de marcador de posición
                            }
                        }
                        else
                        {
                            // Asignar una imagen de marcador de posición o mostrar un mensaje de error si la URL de la imagen es nula o vacía
                            pcbNoticia3.Image = Properties.Resources.lgo; // Ejemplo de imagen de marcador de posición
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al cargar noticias: {ex.Message}");
            }
            finally
            {
                // Oculta el GIF de carga
                pcbGifCarga.Visible = false;
            }
        }

        private void FrmNoticias_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
