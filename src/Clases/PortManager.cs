using System;
using System.Net;
using System.Net.Sockets;


namespace pet4sitter
{
    public class PortManager
    {
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
                // El puerto está disponible si ocurre una excepción al conectar
            }
            return isAvailable;
        }
    }
}
