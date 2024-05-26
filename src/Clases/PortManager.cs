using System;
using System.Net;
using System.Net.Sockets;

namespace pet4sitter
{
    /// <summary>
    /// La clase PortManager proporciona métodos para encontrar puertos disponibles en un rango especificado.
    /// </summary>
    public class PortManager
    {
        /// <summary>
        /// Encuentra un puerto disponible dentro de un rango de puertos especificado.
        /// </summary>
        /// <param name="startingPort">El puerto de inicio del rango.</param>
        /// <param name="endingPort">El puerto de fin del rango.</param>
        /// <returns>Un puerto disponible dentro del rango especificado, o -1 si no hay puertos disponibles.</returns>
        public static int FindAvailablePort(int startingPort, int endingPort)
        {
            for (int port = startingPort; port <= endingPort; port++)
            {
                if (IsPortAvailable(port))
                {
                    return port;
                }
            }
            return -1;
        }

        /// <summary>
        /// Verifica si un puerto específico está disponible.
        /// </summary>
        /// <param name="port">El puerto a verificar.</param>
        /// <returns>True si el puerto está disponible, false en caso contrario.</returns>
        private static bool IsPortAvailable(int port)
        {
            bool isAvailable = true;
            try
            {
                using (var client = new TcpClient())
                {
                    client.Connect(IPAddress.Loopback, port);
                    isAvailable = false;
                }
            }
            catch (SocketException)
            {
                // El puerto está disponible si ocurre una excepción al intentar conectar.
            }
            return isAvailable;
        }
    }
}
