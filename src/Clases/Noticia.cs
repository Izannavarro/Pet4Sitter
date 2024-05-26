using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter.Clases
{
    public class Noticia
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public string UrlImagen;

        //Clase Noticia
        public Noticia(string titulo, string descripcion, string url, string urlImagen)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Url = url;
            UrlImagen = urlImagen;
        }
    }
}
