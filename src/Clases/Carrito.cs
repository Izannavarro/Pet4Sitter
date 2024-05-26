using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter.Clases
{
    //Clase Carrito Para almacenar lista de productos y sus respectivos atributos
    static class Carrito
    {
        private static List<Producto> productos = new List<Producto>();

        public static List<Producto> Productos { get { return productos; }  set{productos = value;} }

        /// <summary>
        /// Método que retorna el indice de un producto en concreto.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método para obtener la suma del precio de los artículos
        /// </summary>
        /// <param name="lprod"></param>
        /// <returns></returns>
        public static double ObtenerPrecioTotal(List<Producto> lprod)
        {
            double total = 0;
            foreach (Producto p in lprod)
            {
                total += p.Precio * p.Cantidad;
            }
            return total;
        }

        public static bool HaCambiadoLaCantidad(List<Producto> lprod)
        {
            if (lprod == null || lprod.Count != productos.Count)
            {
                return true;
            }

            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].Id != lprod[i].Id || productos[i].Cantidad != lprod[i].Cantidad)
                {
                    return true;
                }
            }

            return false;
        }

        public static List<Producto> CopiarProductos(List<Producto> productos)
        {
            return productos.Select(p => new Producto(p.Id, p.NombreProducto, p.Cantidad, p.Precio, p.Descripcion, p.UrlImagen)).ToList();
        }

    }
}
