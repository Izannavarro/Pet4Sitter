using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace pet4sitter.Clases
{
    //Clase para la API de noticias
    public class NewsFetcher
    {
        private readonly NewsApiClient _newsApiClient;


        public NewsFetcher(string apiKey)
        {
            _newsApiClient = new NewsApiClient(apiKey);
        }

        /// <summary>
        /// Recupera una noticia relacionada con animales de una fuente de noticias externa.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica. La tarea devuelve un objeto Noticia si se encuentra una noticia, o lanza una excepción si no se encuentran noticias.</returns>
        public async Task<Noticia> FetchAnimalNews()
        {
            try
            {
                // Obtener el código de idioma actual de la configuración de la aplicación
                string codigoIdioma = ConfiguracionIdioma.Cultura.Name;

                // Definir la consulta de búsqueda por defecto (en inglés)
                string consulta = "dogs cats animals";
                Languages idioma = Languages.EN;
                if (codigoIdioma == "es-ES")
                {
                    consulta = "perros gatos animales";
                    idioma = Languages.ES;
                }
                var articlesResponse = await _newsApiClient.GetEverythingAsync(new EverythingRequest
                {

                    Q = consulta,
                    Language = idioma
                });

                if (articlesResponse.Status == Statuses.Ok && articlesResponse.TotalResults > 0)
                {
                    Random rnd = new Random();
                    // Obtén el primer artículo
                    var articles = articlesResponse.Articles.ToList();

                    var article = articles[rnd.Next(0, articles.Count)];

                    // Crea y devuelve una instancia de Noticia
                    return new Noticia(article.Title, article.Content, article.Url, article.UrlToImage);
                }
                else
                {
                    throw new Exception("No se encontraron noticias de animales.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener noticias de animales: {ex.Message}");
            }
        }

        /// <summary>
        /// Recupera una lista de noticias relacionadas con animales de una fuente de noticias externa.
        /// </summary>
        /// <returns>
        /// Una tarea que representa la operación asincrónica. 
        /// La tarea devuelve una lista de objetos Noticia si se encuentran noticias, 
        /// o lanza una excepción si no se encuentran noticias.
        /// </returns>
        public async Task<List<Noticia>> FetchAnimalNewsList()
        {
            try
            {
                // Obtener el código de idioma actual de la configuración de la aplicación
                string codigoIdioma = ConfiguracionIdioma.Cultura.Name;

                // Definir la consulta de búsqueda por defecto (en inglés)
                string consulta = "dogs cats animals";
                Languages idioma = Languages.EN;
                if (codigoIdioma == "es-ES")
                {
                    consulta = "perros gatos animales";
                    idioma = Languages.ES;
                }
                var articlesResponse = await _newsApiClient.GetEverythingAsync(new EverythingRequest
                {

                    Q = consulta,
                    Language = idioma
                });

                if (articlesResponse.Status == Statuses.Ok && articlesResponse.TotalResults > 0)
                {
                    // Convertimos la lista de artículos de la respuesta a una lista de instancias de Noticia
                    var noticias = articlesResponse.Articles.Select(article =>
                        new Noticia(article.Title, article.Content, article.Url, article.UrlToImage)).ToList();

                    return noticias;
                }
                else
                {
                    throw new Exception("No se encontraron noticias de animales.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener noticias de animales: {ex.Message}");
            }
        }


    }
}
