using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter.Clases
{
    public class Tarjeta
    {
        private int numeroTarjeta;
        private string titularTarjeta;
        private string fechaCaducidad;
        private int cvc;

        public int NumeroTarjeta { get { return numeroTarjeta; } }
        public string TitularTarjeta { get { return titularTarjeta; } }
        public string FechaCaducidad { get { return fechaCaducidad; } }
        public int Cvc { get { return cvc; } }

        public Tarjeta(int numTarg, string titular, string fecha, int cvc)
        {
            numeroTarjeta = numTarg;
            titularTarjeta = titular;
            fechaCaducidad = fecha;
            this.cvc = cvc;
        }
    }
}
