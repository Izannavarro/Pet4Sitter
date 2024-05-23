using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter.Clases
{
    public static class Tarjeta
    {
        private static int numeroTarjeta;
        private static string titularTarjeta;
        private static string fechaCaducidad;
        private static int cvc;

        public static int NumeroTarjeta { get { return numeroTarjeta; } }
        public static string TitularTarjeta { get { return titularTarjeta; } }
        public static string FechaCaducidad { get { return fechaCaducidad; } }
        public static int Cvc { get { return cvc; } }
    }
}
