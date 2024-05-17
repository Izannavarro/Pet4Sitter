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
        private Image imagen;

        public string NombreProducto { get { return nombreProducto; } }
        public int Cantidad { get { return cantidad; } }
        public double Precio { get { return precio; } }
        public string Descripcion { get { return descripcion; } }

        public Producto(string nom, int cant,double pre, string descr, Image img)
        {
            nombreProducto = nom;
            cantidad = cant;
            precio = pre;
            descripcion = descr;
            imagen = img;
        }

        public void AnyadirProducto(Producto p)
        {
            string consulta = "INSERT INTO products (name, price, quantity,description) VALUES ('{0}', '{1}', '{2}','{3}')",p.;
        }
    }
}
