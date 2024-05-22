using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace pet4sitter.Clases
{
    public class NewsFetcher
    {
        private readonly NewsApiClient _newsApiClient;


        public NewsFetcher(string apiKey)
        {
            _newsApiClient = new NewsApiClient(apiKey);
        }

        public async Task<Noticia> FetchAnimalNews()
        {
            try
            {
                var articlesResponse = await _newsApiClient.GetEverythingAsync(new EverythingRequest
                {
                    Q = "perros gatos animales",
                    Language = Languages.ES, // Opcional: Cambia a tu idioma preferido
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


        public async Task<List<Noticia>> FetchAnimalNewsList()
        {
            try
            {
                var articlesResponse = await _newsApiClient.GetEverythingAsync(new EverythingRequest
                {
                    Q = "perros gatos animales",
                    Language = Languages.ES, // Opcional: Cambia a tu idioma preferido
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
