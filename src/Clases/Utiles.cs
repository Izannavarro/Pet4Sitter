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
using MySql.Data.MySqlClient;
using System.Data;

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

        public static string CargarTokenGpt()
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
                    return tokenJson["GPT"].ToString();
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


        public static DataTable ExecuteQuery(string query)
        {
            // Create a new DataTable to hold the query results
            DataTable dataTable = new DataTable();

            try
            {
                // Create a new MySqlCommand with the provided query and connection
                MySqlCommand command = new MySqlCommand(query, ConBD.Conexion);

                // Create a new MySqlDataAdapter to execute the query and fill the DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Fill the DataTable with the query results
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Return the filled DataTable
            return dataTable;
        }

        public static DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                    using (MySqlCommand cmd = new MySqlCommand(query, ConBD.Conexion))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ejecutando la consulta: {ex.Message}");
            }
            return dt;
        }

    }
}
