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
        private long numeroTarjeta;
        private string titularTarjeta;
        private DateTime fechaCaducidad;
        private int cvc;

        public long NumeroTarjeta { get { return numeroTarjeta; } }
        public string TitularTarjeta { get { return titularTarjeta; } }
        public DateTime FechaCaducidad { get { return fechaCaducidad; } }
        public int Cvc { get { return cvc; } }

        public Tarjeta(long numTarg, string titular, DateTime fecha, int cvc)
        {
            numeroTarjeta = numTarg;
            titularTarjeta = titular;
            fechaCaducidad = fecha;
            this.cvc = cvc;
        }

        public override string ToString()
        {
            string numTarjetaStr = numeroTarjeta.ToString();
            string ultimosCuatroDigitos = numTarjetaStr.Length >= 4 ? numTarjetaStr.Substring(numTarjetaStr.Length - 4) : numTarjetaStr;

            return $"Titular: {titularTarjeta}\nNúmero de Tarjeta:\n**** **** **** {ultimosCuatroDigitos}\nFecha de Caducidad:\n{fechaCaducidad.Month}/{fechaCaducidad.Year}";
        }

    }
}
