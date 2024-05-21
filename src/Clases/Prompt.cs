using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter
{
    public class Prompt
    {
        string input;
        string output;
        DateTime time = DateTime.Now;

        public Prompt(string input, string output)
        {
            this.input = input;
            this.output = output;
        }

        public string Input { get { return input; } }
        public string Output { get { return output; } }

    }
}
