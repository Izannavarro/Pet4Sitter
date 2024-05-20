using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter.Clases
{
     class Producto
    {
        private int? id;
        private static int sumatorio = 1;
        private string nombreProducto;
        private int cantidad;
        private double precio;
        private string descripcion;
        private string urlImagen;

        public int? Id { get { return id; } }
        public string NombreProducto { get { return nombreProducto; } }
        public int Cantidad { get { return cantidad; } }
        public double Precio { get { return precio; } }
        public string Descripcion { get { return descripcion; } }
        public string UrlImagen { get { return urlImagen; } }


        public Producto( int? id, string nom, int cant,double pre, string descr, string img)
        {
            this.id = id;
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
                string consulta = string.Format("INSERT INTO products (name, price, quantity, description,image) VALUES ('{0}', '{1}', '{2}','{3}','{4}')", p.NombreProducto, p.Precio, p.Cantidad, p.Descripcion,p.UrlImagen);
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                MessageBox.Show("Error al añadir producto: " + ex.Message);
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
                        int i = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        double precio = reader.GetDouble(2);
                        int cantidad = reader.GetInt32(3);
                        string descripcion = reader.GetString(4);
                        productos.Add(new Producto(i,nombre, cantidad, precio, descripcion, null));
                    }
                    reader.Close();
                    return productos;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar los productos: " + ex.Message);
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
                Producto p = new Producto(int.Parse(reader["id_product"].ToString()),reader["name"].ToString(), int.Parse(reader["quantity"].ToString()), double.Parse(reader["price"].ToString()), reader["description"].ToString(), reader["image"].ToString());
                lProd.Add(p);
            }
            return lProd;
        }

        public static void EliminarProducto(int id)
        {
            try
            {
                string consulta = string.Format("DELETE FROM products WHERE id_product = '{0}'", id);
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Close();
            }

            catch (Exception ex)
            {
                // Manejar excepciones
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        public static void ActualizarProducto(Producto p1)
        {
            try
            {
                string consulta = string.Format("UPDATE products set name = '{0}' ,quantity = '{1}', price = '{2}', description = '{3}', image = '{4}' WHERE id_product = '{5}'", p1.NombreProducto, p1.Cantidad, p1.Precio, p1.Descripcion, p1.UrlImagen, p1.Id);
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Close();
            }

            catch (Exception ex)
            {
                // Manejar excepciones
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

    }
}
