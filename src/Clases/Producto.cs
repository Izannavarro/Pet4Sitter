using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter.Clases
{
     class Producto
    {
        private string nombreProducto;
        private int cantidad;
        private double precio;
        private string descripcion;
        private string urlImagen;

        public string NombreProducto { get { return nombreProducto; } }
        public int Cantidad { get { return cantidad; } }
        public double Precio { get { return precio; } }
        public string Descripcion { get { return descripcion; } }
        public string UrlImagen { get { return urlImagen; } }


        public Producto(string nom, int cant,double pre, string descr, string img)
        {
            nombreProducto = nom;
            cantidad = cant;
            precio = pre;
            descripcion = descr;
            urlImagen = img;
        }

        public static void AnyadirProducto(Producto p)
        {
            try
            {
                string consulta = string.Format("INSERT INTO products (name, price, quantity, description,image) VALUES ('{0}', '{1}', '{2}','{3}')", p.NombreProducto, p.Precio, p.Cantidad, p.Descripcion,p.UrlImagen);
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                Console.WriteLine("Error al añadir producto: " + ex.Message);
            }
        }

        public static List<Producto> CantidadProductos()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                string consulta = string.Format("SELECT * FROM products");
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string nombre = reader.GetString(1);
                        double precio = reader.GetDouble(2);
                        int cantidad = reader.GetInt32(3);
                        string descripcion = reader.GetString(4);
                        productos.Add(new Producto(nombre, cantidad, precio, descripcion, reader["urlImagen"].ToString()));
                    }
                }
                reader.Close();
                return productos;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Cargar los productos: " + ex.Message);
            }
            return productos;
        }

        public static List<Producto> ListarProductos(string query)
        {
            List<Producto> lProd = new List<Producto>();
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Producto p = new Producto(reader["name"].ToString(), int.Parse(reader["quantity"].ToString()), double.Parse(reader["price"].ToString()), reader["description"].ToString(), reader["image"].ToString());
                lProd.Add(p);
            }
            return lProd;
        }

    }
}
