using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter.Clases
{
    /// <summary>
    /// La clase Producto representa un producto en la aplicación con sus propiedades y métodos asociados para interactuar con la base de datos.
    /// </summary>
    public class Producto
    {
        private int? id;
        private string nombreProducto;
        private int cantidad;
        private double precio;
        private string descripcion;
        private Image urlImagen;

        /// <summary>
        /// Obtiene el identificador del producto.
        /// </summary>
        public int? Id { get { return id; } }

        /// <summary>
        /// Obtiene el nombre del producto.
        /// </summary>
        public string NombreProducto { get { return nombreProducto; } }

        /// <summary>
        /// Obtiene o establece la cantidad del producto.
        /// </summary>
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }

        /// <summary>
        /// Obtiene el precio del producto.
        /// </summary>
        public double Precio { get { return precio; } }

        /// <summary>
        /// Obtiene la descripción del producto.
        /// </summary>
        public string Descripcion { get { return descripcion; } }

        /// <summary>
        /// Obtiene la imagen del producto.
        /// </summary>
        public Image UrlImagen { get { return urlImagen; } }

        /// <summary>
        /// Constructor para crear una nueva instancia de Producto.
        /// </summary>
        /// <param name="id">El identificador del producto.</param>
        /// <param name="nom">El nombre del producto.</param>
        /// <param name="cant">La cantidad del producto.</param>
        /// <param name="pre">El precio del producto.</param>
        /// <param name="descr">La descripción del producto.</param>
        /// <param name="img">La imagen del producto.</param>
        public Producto(int? id, string nom, int cant, double pre, string descr, Image img)
        {
            this.id = id;
            nombreProducto = nom;
            cantidad = cant;
            precio = pre;
            descripcion = descr;
            urlImagen = img;
        }

        /// <summary>
        /// Añade un nuevo producto a la base de datos.
        /// </summary>
        /// <param name="p">La instancia del producto a añadir.</param>
        public static void AnyadirProducto(Producto p)
        {
            try
            {
                byte[] imgArr = Utiles.ImageToByteArray(p.UrlImagen);
                string consulta = "INSERT INTO products (name, price, quantity, description, image) VALUES (@nombre, @precio, @cantidad, @descripcion, @imagen)";
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                comando.Parameters.AddWithValue("@nombre", p.NombreProducto);
                comando.Parameters.AddWithValue("@precio", p.Precio);
                comando.Parameters.AddWithValue("@cantidad", p.Cantidad);
                comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
                comando.Parameters.AddWithValue("@imagen", imgArr);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir producto: " + ex.Message);
            }
        }

        /// <summary>
        /// Obtiene una lista de todos los productos en la base de datos.
        /// </summary>
        /// <returns>Una lista de productos.</returns>
        public static List<Producto> CantidadProductos()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                string consulta = "SELECT * FROM products";
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int i = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    double precio = reader.GetDouble(2);
                    int cantidad = reader.GetInt32(3);
                    string descripcion = reader.GetString(4);

                    byte[] array = null;
                    if (!reader.IsDBNull(5))
                    {
                        long length = reader.GetBytes(5, 0, null, 0, 0);
                        array = new byte[length];
                        reader.GetBytes(5, 0, array, 0, (int)length);
                    }

                    Image img = null;
                    if (array != null)
                    {
                        img = Utiles.ByteArrayToImage(array);
                    }

                    productos.Add(new Producto(i, nombre, cantidad, precio, descripcion, img));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
            return productos;
        }

        /// <summary>
        /// Obtiene una lista de productos según la consulta especificada.
        /// </summary>
        /// <param name="query">La consulta SQL para filtrar los productos.</param>
        /// <returns>Una lista de productos.</returns>
        public static List<Producto> ListarProductos(string query)
        {
            List<Producto> lProd = new List<Producto>();
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                byte[] imgArr = reader["image"] as byte[];
                Image img = Utiles.ByteArrayToImage(imgArr);

                Producto p = new Producto(int.Parse(reader["id_product"].ToString()), reader["name"].ToString(), int.Parse(reader["quantity"].ToString()), double.Parse(reader["price"].ToString()), reader["description"].ToString(), img);
                lProd.Add(p);
            }
            reader.Close();
            return lProd;
        }

        /// <summary>
        /// Elimina un producto de la base de datos.
        /// </summary>
        /// <param name="id">El identificador del producto a eliminar.</param>
        public static void EliminarProducto(int id)
        {
            try
            {
                string consulta = "DELETE FROM products WHERE id_product = @id";
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza los datos de un producto en la base de datos.
        /// </summary>
        /// <param name="p1">La instancia del producto con los nuevos datos.</param>
        public static void ActualizarProducto(Producto p1)
        {
            try
            {
                string consulta;
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = ConBD.Conexion;

                if (p1.UrlImagen != null)
                {
                    byte[] imgArr = Utiles.ImageToByteArray(p1.UrlImagen);
                    consulta = "UPDATE products SET name = @nombre, quantity = @cantidad, price = @precio, description = @descripcion, image = @imagen WHERE id_product = @id";
                    comando.Parameters.AddWithValue("@imagen", imgArr);
                }
                else
                {
                    consulta = "UPDATE products SET name = @nombre, quantity = @cantidad, price = @precio, description = @descripcion WHERE id_product = @id";
                }

                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@nombre", p1.NombreProducto);
                comando.Parameters.AddWithValue("@cantidad", p1.Cantidad);
                comando.Parameters.AddWithValue("@precio", p1.Precio);
                comando.Parameters.AddWithValue("@descripcion", p1.Descripcion);
                comando.Parameters.AddWithValue("@id", p1.Id);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }


        /// <summary>
        /// Busca productos por nombre en la base de datos.
        /// </summary>
        /// <param name="nombreProducto">El nombre del producto a buscar.</param>
        /// <returns>Una lista de productos que coinciden con el nombre especificado.</returns>
        public static List<Producto> EncontrarNombreProducto(string nombreProducto)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                string consulta = "SELECT * FROM products WHERE name LIKE @nombre";
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                comando.Parameters.AddWithValue("@nombre", nombreProducto + "%");
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int i = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    double precio = reader.GetDouble(2);
                    int cantidad = reader.GetInt32(3);
                    string descripcion = reader.GetString(4);

                    byte[] array = null;
                    if (!reader.IsDBNull(5))
                    {
                        long length = reader.GetBytes(5, 0, null, 0, 0);
                        array = new byte[length];
                        reader.GetBytes(5, 0, array, 0, (int)length);
                    }

                    Image img = null;
                    if (array != null)
                    {
                        img = Utiles.ByteArrayToImage(array);
                    }

                    productos.Add(new Producto(i, nombre, cantidad, precio, descripcion, img));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar el producto por: " + ex.Message);
            }
            return productos;
        }

        /// <summary>
        /// Obtiene una lista de productos ordenados por precio de mayor a menor.
        /// </summary>
        /// <returns>Una lista de productos ordenados por precio de mayor a menor.</returns>
        public static List<Producto> ProductosMayorMenor()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                string consulta = "SELECT * FROM products ORDER BY price DESC";
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int i = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    double precio = reader.GetDouble(2);
                    int cantidad = reader.GetInt32(3);
                    string descripcion = reader.GetString(4);

                    byte[] array = null;
                    if (!reader.IsDBNull(5))
                    {
                        long length = reader.GetBytes(5, 0, null, 0, 0);
                        array = new byte[length];
                        reader.GetBytes(5, 0, array, 0, (int)length);
                    }

                    Image img = null;
                    if (array != null)
                    {
                        img = Utiles.ByteArrayToImage(array);
                    }

                    productos.Add(new Producto(i, nombre, cantidad, precio, descripcion, img));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los productos por: " + ex.Message);
            }
            return productos;
        }

        /// <summary>
        /// Obtiene una lista de productos ordenados por precio de menor a mayor.
        /// </summary>
        /// <returns>Una lista de productos ordenados por precio de menor a mayor.</returns>
        public static List<Producto> ProductosMenorMayor()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                string consulta = "SELECT * FROM products ORDER BY price ASC";
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int i = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    double precio = reader.GetDouble(2);
                    int cantidad = reader.GetInt32(3);
                    string descripcion = reader.GetString(4);

                    byte[] array = null;
                    if (!reader.IsDBNull(5))
                    {
                        long length = reader.GetBytes(5, 0, null, 0, 0);
                        array = new byte[length];
                        reader.GetBytes(5, 0, array, 0, (int)length);
                    }

                    Image img = null;
                    if (array != null)
                    {
                        img = Utiles.ByteArrayToImage(array);
                    }

                    productos.Add(new Producto(i, nombre, cantidad, precio, descripcion, img));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los productos por: " + ex.Message);
            }
            return productos;
        }
    }
}