using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace piTest.Clases
{
    public class GeoLocalizacion
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<(double? Latitude, double? Longitude)> ObtenerCoordenadasAsync(string direccion)
        {
            try
            {
                // Agregar un encabezado User-Agent
                client.DefaultRequestHeaders.Add("User-Agent", "YourUserAgent");

                string url = $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(direccion)}&format=json&addressdetails=1&limit=1";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Lanza una excepción si la solicitud no tiene éxito

                string json = await response.Content.ReadAsStringAsync();
                JArray jsonArray = JArray.Parse(json);

                if (jsonArray.Count > 0)
                {
                    double lat = (double)jsonArray[0]["lat"];
                    double lon = (double)jsonArray[0]["lon"];

                    // Agregar un retraso entre solicitudes
                    await Task.Delay(1000); // Espera 1 segundo (ajusta el valor según sea necesario)

                    return (lat, lon);
                }
                else
                {
                    return (null, null);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante la solicitud
                Console.WriteLine($"Error en la solicitud de coordenadsas: {ex.Message}");
                return (null, null);
            }
        }
    }
}
