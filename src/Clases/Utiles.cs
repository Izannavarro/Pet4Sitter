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
using System.Security.Cryptography;

namespace pet4sitter.Clases
{
    /// <summary>
    /// Clase que proporciona métodos útiles para diversas tareas.
    /// </summary>
    public class Utiles
    {
        /// <summary>
        /// Busca un token en la base de datos por su nombre.
        /// </summary>
        /// <param name="nombre">El nombre del token a buscar.</param>
        /// <returns>El valor del token si se encuentra; de lo contrario, devuelve "none".</returns>
        public static string BuscarToken(string nombre)
        {
            // Verificar la conexión a la base de datos
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                string query = "SELECT token_value FROM tokens WHERE token_name=@name;";
                MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
                com.Parameters.AddWithValue("name", nombre);
                string tokenValue = com.ExecuteScalar()?.ToString(); // Ejecuta el comando y obtén el valor del token
                ConBD.CerrarConexion();
                return tokenValue ?? "none"; // Si el tokenValue es null, devuelve "none"
            }
            return "none";
        }

        /// <summary>
        /// Genera una contraseña aleatoria de la longitud especificada.
        /// </summary>
        /// <param name="length">La longitud de la contraseña.</param>
        /// <returns>Una cadena que representa la contraseña aleatoria generada.</returns>
        public static string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Convierte un objeto Bitmap en un objeto Icon.
        /// </summary>
        /// <param name="bitmap">El objeto Bitmap a convertir.</param>
        /// <returns>El objeto Icon resultante.</returns>
        public static Icon BitmapToIcon(Bitmap bitmap)
        {
            // Crear un archivo temporal para el ícono
            string tempFilePath = Path.Combine(Path.GetTempPath(), "tempIcon.ico");

            using (FileStream fs = new FileStream(tempFilePath, FileMode.Create))
            {
                bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            }

            // Convertir el archivo temporal de imagen a ícono
            Icon icon = IconFromHandle(tempFilePath);

            // Borrar el archivo temporal
            File.Delete(tempFilePath);

            return icon;
        }

        /// <summary>
        /// Convierte un archivo de imagen en un objeto Icon.
        /// </summary>
        /// <param name="filePath">La ruta del archivo de imagen.</param>
        /// <returns>El objeto Icon resultante.</returns>
        private static Icon IconFromHandle(string filePath)
        {
            using (var bmp = new Bitmap(filePath))
            {
                IntPtr hicon = bmp.GetHicon();
                return Icon.FromHandle(hicon);
            }
        }

        /// <summary>
        /// Obtiene la altura del texto en un control Label.
        /// </summary>
        /// <param name="lbl">El control Label que contiene el texto.</param>
        /// <returns>La altura del texto en el control Label.</returns>
        public static int ObtenerAlturaTexto(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, lbl.Width);
                int padding = 10; // Añadir margen para asegurar que el texto no se corte
                return (int)Math.Ceiling(size.Height) + padding;
            }
        }

        /// <summary>
        /// Convierte una imagen en un arreglo de bytes.
        /// </summary>
        /// <param name="imageIn">La imagen a convertir.</param>
        /// <returns>El arreglo de bytes que representa la imagen.</returns>
        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Convierte un arreglo de bytes en una imagen.
        /// </summary>
        /// <param name="byteArrayIn">El arreglo de bytes que representa la imagen.</param>
        /// <returns>La imagen resultante.</returns>
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados en un DataTable.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <returns>Un DataTable que contiene los resultados de la consulta.</returns>
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

        /// <summary>
        /// Ejecuta una consulta SQL parametrizada y devuelve los resultados en un DataTable.
        /// </summary>
        /// <param name="query">La consulta SQL parametrizada a ejecutar.</param>
        /// <param name="parameters">Los parámetros de la consulta.</param>
        /// <returns>Un DataTable que contiene los resultados de la consulta.</returns>
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

        /// <summary>
        /// Verifica la validez de un número de DNI (Documento Nacional de Identidad) español.
        /// </summary>
        /// <param name="dni">El número de DNI a verificar.</param>
        /// <returns>True si el DNI es válido; de lo contrario, false.</returns>
        public static bool CheckDNI(string dni)
        {
            // Verificar la longitud del DNI
            if (dni.Length != 9)
            {
                return false;
            }

            // Extraer los números y la letra del DNI
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLetter = dni.Substring(dni.Length - 1, 1);

            // Intentar convertir los números del DNI a formato numérico
            if (!int.TryParse(dniNumbers, out int dniInteger))
            {
                // No se pudo convertir los números a formato numérico
                return false;
            }

            // Verificar la letra del DNI
            if (CalculateDNILeter(dniInteger) != dniLetter)
            {
                // La letra del DNI es incorrecta
                return false;
            }

            // El DNI es válido
            return true;
        }

        /// <summary>
        /// Calcula la letra correspondiente a los números de un DNI español.
        /// </summary>
        /// <param name="dniNumbers">Los números del DNI.</param>
        /// <returns>La letra correspondiente a los números del DNI.</returns>
        public static string CalculateDNILeter(int dniNumbers)
        {
            // Cargar los dígitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

            // Calcular el dígito de control
            var mod = dniNumbers % 23;

            // Devolver la letra correspondiente al dígito de control
            return control[mod];
        }
    }
}
