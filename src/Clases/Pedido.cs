using MySql.Data.MySqlClient;
using pet4sitter.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace pet4sitter.Clases
{
    /// <summary>
    /// La clase Pedido representa un pedido realizado por un usuario, incluyendo la localización y los productos.
    /// </summary>
    public class Pedido
    {
        private int? idUsuario;
        private string localizacion;
        private List<Producto> productos;

        /// <summary>
        /// Obtiene el ID del usuario que realizó el pedido.
        /// </summary>
        public int? IdUsuario
        {
            get { return this.idUsuario; }
        }

        /// <summary>
        /// Obtiene o establece la localización de entrega del pedido.
        /// </summary>
        public string Localizacion
        {
            get { return this.localizacion; }
            set { this.localizacion = value; }
        }

        /// <summary>
        /// Obtiene la lista de productos incluidos en el pedido.
        /// </summary>
        public List<Producto> Productos { get { return this.productos; } }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Pedido con los parámetros especificados.
        /// </summary>
        /// <param name="idUsuario">ID del usuario que realizó el pedido.</param>
        /// <param name="localizacion">Localización de entrega del pedido.</param>
        /// <param name="productos">Lista de productos incluidos en el pedido.</param>
        public Pedido(int? idUsuario, string localizacion, List<Producto> productos)
        {
            this.idUsuario = idUsuario;
            this.localizacion = localizacion;
            this.productos = productos;
        }

        /// <summary>
        /// Guarda el pedido en la base de datos.
        /// </summary>
        /// <param name="pedido">El pedido a guardar.</param>
        public static void GuardarPedido(Pedido pedido)
        {
            string query = "INSERT INTO `pet4sitter`.`delivery` (`id_receiver`, `delivery_date`, `direction`) VALUES (@idUsuario, @fecha, @dirección);";
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
                com.Parameters.AddWithValue("@idUsuario", pedido.IdUsuario);
                com.Parameters.AddWithValue("@fecha", DateTime.Now);
                com.Parameters.AddWithValue("@dirección", pedido.Localizacion);
                com.ExecuteNonQuery();
                ConBD.CerrarConexion();
            }
        }

        /// <summary>
        /// Obtiene el ID del último pedido guardado en la base de datos.
        /// </summary>
        /// <returns>El ID del último pedido.</returns>
        public static int ObtenerIdUltimoPedido()
        {
            string query = "SELECT MAX(id_delivery) FROM delivery;";
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    ConBD.CerrarConexion();
                    return id;
                }
                ConBD.CerrarConexion();
            }
            return -1;
        }

        /// <summary>
        /// Guarda los productos asociados a un pedido en la base de datos.
        /// </summary>
        /// <param name="idPedido">ID del pedido.</param>
        /// <param name="productos">Lista de productos a guardar.</param>
        /// <returns>Devuelve -1 si la operación falla.</returns>
        public static int GuardarProductosPedido(int idPedido, List<Producto> productos)
        {
            string query = "INSERT INTO `pet4sitter`.`delivery_products` (`id_delivery`, `id_product`) VALUES (@idPedido, @idProducto);";
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
                com.Parameters.AddWithValue("@idPedido", idPedido);
                foreach (Producto p in productos)
                {
                    com.Parameters.AddWithValue("@idProducto", p.Id);
                    com.ExecuteNonQuery();
                    com.Parameters.RemoveAt("@idProducto");
                }
                ConBD.CerrarConexion();
            }
            return -1;
        }

        /// <summary>
        /// Genera un HTML con los detalles del pedido.
        /// </summary>
        /// <param name="pedido">El pedido cuyos detalles se quieren generar.</param>
        /// <returns>El HTML generado en formato string.</returns>
        public static string GenerarHtmlPedido(Pedido pedido)
        {
            var sb = new StringBuilder();

            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html lang=\"es\">");
            sb.AppendLine("<head>");
            sb.AppendLine("    <meta charset=\"UTF-8\">");
            sb.AppendLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            sb.AppendLine("    <style>");
            sb.AppendLine("        body { font-family: Arial, sans-serif; line-height: 1.6; margin: 0; padding: 0; background-color: #f4f4f4; }");
            sb.AppendLine("        .container { width: 80%; margin: auto; overflow: hidden; background: #fff; padding: 20px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); }");
            sb.AppendLine("        .header, .footer { background: #333; color: #fff; padding: 10px 0; text-align: center; }");
            sb.AppendLine("        .header h1, .footer p { margin: 0; }");
            sb.AppendLine("        .order-details { margin: 20px 0; }");
            sb.AppendLine("        .order-details h2 { color: #333; border-bottom: 2px solid #f4f4f4; padding-bottom: 5px; }");
            sb.AppendLine("        .order-details p { margin: 5px 0; }");
            sb.AppendLine("        .order-details .product { border-bottom: 1px solid #f4f4f4; padding-bottom: 5px; margin-bottom: 5px; }");
            sb.AppendLine("    </style>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            sb.AppendLine("    <div class=\"header\">");
            sb.AppendLine("        <h1>Detalles de tu pedido</h1>");
            sb.AppendLine("    </div>");
            sb.AppendLine("    <div class=\"container\">");
            sb.AppendLine("        <div class=\"order-details\">");
            sb.AppendLine($"            <h2>Número de Pedido: {pedido.IdUsuario}</h2>");
            sb.AppendLine($"            <p><strong>Localización:</strong> {pedido.Localizacion}</p>");
            sb.AppendLine("            <h3>Productos:</h3>");

            foreach (var producto in pedido.Productos)
            {
                sb.AppendLine("            <div class=\"product\">");
                sb.AppendLine($"                <p><strong>Nombre:</strong> {producto.NombreProducto}</p>");
                sb.AppendLine($"                <p><strong>Cantidad:</strong> {producto.Cantidad}</p>");
                sb.AppendLine($"                <p><strong>Precio:</strong> {producto.Precio} EUR</p>");
                sb.AppendLine("            </div>");
            }

            var total = Carrito.ObtenerPrecioTotal(pedido.Productos);
            sb.AppendLine($"            <h3>Total: {total} EUR</h3>");
            sb.AppendLine("        </div>");
            sb.AppendLine("    </div>");
            sb.AppendLine("    <div class=\"footer\">");
            sb.AppendLine("        <p>Gracias por tu compra</p>");
            sb.AppendLine("    </div>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            return sb.ToString();
        }
    }
}
