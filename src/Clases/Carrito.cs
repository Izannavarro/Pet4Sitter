using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter.Clases
{
    static class Carrito
    {
        private static List<Producto> productos = new List<Producto>();

        public static List<Producto> Productos { get { return productos; }  set{productos = value;} }

        public static int IndiceProducto(int id)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public static double ObtenerPrecioTotal(List<Producto> lprod)
        {
            double total = 0;
            foreach (Producto p in lprod)
            {
                total += p.Precio;
            }
            return total;
        }
    }
}
