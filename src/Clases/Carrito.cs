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

        public static List<Producto> Productos { get { return productos; } }


    }
}
