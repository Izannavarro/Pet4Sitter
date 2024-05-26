using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter.Clases
{
    /// <summary>
    /// La clase Tarjeta representa una tarjeta de crédito o débito, almacenando el número de tarjeta, el titular, la fecha de caducidad y el código CVC.
    /// </summary>
    public class Tarjeta
    {
        private long numeroTarjeta;
        private string titularTarjeta;
        private DateTime fechaCaducidad;
        private int cvc;

        /// <summary>
        /// Obtiene el número de la tarjeta.
        /// </summary>
        public long NumeroTarjeta { get { return numeroTarjeta; } }

        /// <summary>
        /// Obtiene el nombre del titular de la tarjeta.
        /// </summary>
        public string TitularTarjeta { get { return titularTarjeta; } }

        /// <summary>
        /// Obtiene la fecha de caducidad de la tarjeta.
        /// </summary>
        public DateTime FechaCaducidad { get { return fechaCaducidad; } }

        /// <summary>
        /// Obtiene el código CVC de la tarjeta.
        /// </summary>
        public int Cvc { get { return cvc; } }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Tarjeta con los valores especificados para el número de tarjeta, el titular, la fecha de caducidad y el CVC.
        /// </summary>
        /// <param name="numTarg">El número de la tarjeta.</param>
        /// <param name="titular">El nombre del titular de la tarjeta.</param>
        /// <param name="fecha">La fecha de caducidad de la tarjeta.</param>
        /// <param name="cvc">El código CVC de la tarjeta.</param>
        public Tarjeta(long numTarg, string titular, DateTime fecha, int cvc)
        {
            numeroTarjeta = numTarg;
            titularTarjeta = titular;
            fechaCaducidad = fecha;
            this.cvc = cvc;
        }

        /// <summary>
        /// Devuelve una cadena que representa la instancia actual de la clase Tarjeta.
        /// </summary>
        /// <returns>Una cadena que contiene el titular, los últimos cuatro dígitos del número de tarjeta y la fecha de caducidad.</returns>
        public override string ToString()
        {
            string numTarjetaStr = numeroTarjeta.ToString();
            string ultimosCuatroDigitos = numTarjetaStr.Length >= 4 ? numTarjetaStr.Substring(numTarjetaStr.Length - 4) : numTarjetaStr;

            return $"Titular: {titularTarjeta}\nNúmero de Tarjeta:\n**** **** **** {ultimosCuatroDigitos}\nFecha de Caducidad:\n{fechaCaducidad.Month}/{fechaCaducidad.Year}";
        }
    }
}
