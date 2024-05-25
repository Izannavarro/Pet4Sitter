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
    public class Utiles
    {
        public static string BuscarToken(string nombre)
        {
            if(ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                string query = "SELECT token_value FROM tokens WHERE token_name=@name;";
                MySqlCommand com = new MySqlCommand(query,ConBD.Conexion);
                com.Parameters.AddWithValue("name", nombre);
                string tokenValue = com.ExecuteScalar()?.ToString(); // Ejecuta el comando y obtén el valor del token
                ConBD.CerrarConexion();
                return tokenValue ?? "none"; // Si el tokenValue es null, devuelve "none"
            }
            return "none";
        }
        public static string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
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

        private static Icon IconFromHandle(string filePath)
        {
            using (var bmp = new Bitmap(filePath))
            {
                IntPtr hicon = bmp.GetHicon();
                return Icon.FromHandle(hicon);
            }
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

        public static bool CheckDNI(string dni)
        {
            if (dni.Length != 9)
            {
                return false;
            }

            //Extraemos los números y la letra
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                return false;
            }
            //DNI Valido :)
            return true;
        }


        public static string CalculateDNILeter(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }



    }
}
