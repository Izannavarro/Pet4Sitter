using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter
{
    /// <summary>
    /// La clase Prompt representa un registro de una interacción, almacenando el texto de entrada, el texto de salida y el momento en que se registró la interacción.
    /// </summary>
    public class Prompt
    {
        private string input;
        private string output;
        private DateTime time = DateTime.Now;

        /// <summary>
        /// Inicializa una nueva instancia de la clase Prompt con los valores especificados para la entrada y la salida.
        /// </summary>
        /// <param name="input">El texto de entrada de la interacción.</param>
        /// <param name="output">El texto de salida de la interacción.</param>
        public Prompt(string input, string output)
        {
            this.input = input;
            this.output = output;
        }

        /// <summary>
        /// Obtiene el texto de entrada de la interacción.
        /// </summary>
        public string Input { get { return input; } }

        /// <summary>
        /// Obtiene el texto de salida de la interacción.
        /// </summary>
        public string Output { get { return output; } }

        /// <summary>
        /// Obtiene la fecha y hora en que se registró la interacción.
        /// </summary>
        public DateTime Time { get { return time; } }
    }
}
