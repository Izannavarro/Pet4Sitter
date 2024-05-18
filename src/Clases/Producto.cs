using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piTest.Clases
{
    internal class Producto
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

        public void AnyadirProducto(Producto p)
        {
            //string consulta = "INSERT INTO products (name, price, quantity,description) VALUES ('{0}', '{1}', '{2}','{3}')",p.;
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
