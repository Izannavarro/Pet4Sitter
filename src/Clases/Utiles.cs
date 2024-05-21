using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace pet4sitter.Clases
{
    public class Utiles
    {
        public static string CargarTokenNoticias()
        {
            try
            {
                // Ruta del archivo token.json
                string rutaArchivo = "token.json";

                // Verifica si el archivo existe
                if (File.Exists(rutaArchivo))
                {
                    // Lee el contenido del archivo JSON
                    string contenidoJson = File.ReadAllText(rutaArchivo);

                    // Convierte el contenido a un objeto JSON
                    JObject tokenJson = JObject.Parse(contenidoJson);

                    // Obtén el valor del atributo 'news' y asígnalo a ApiNoticias
                    return tokenJson["News"].ToString();
                }
                else
                {
                    throw new FileNotFoundException("El archivo token.json no fue encontrado.");
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra al cargar el token de noticias
                Console.WriteLine($"Error al cargar el token de noticias: {ex.Message}");
            }
            return "err";
        }

        public static int ObtenerAlturaTexto(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, lbl.Width);
                int padding = 10; // Añadir margen para asegurar que el texto no se corte
                return (int)Math.Ceiling(size.Height) + padding;
            }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
    }
}
