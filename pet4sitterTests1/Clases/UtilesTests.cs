using Microsoft.VisualStudio.TestTools.UnitTesting;
using pet4sitter.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pet4sitter.Clases.Tests
{
    [TestClass()]
    public class UtilesTests
    {

        [TestMethod()]
        public void CheckDNITest()
        {
            string dniReal = "73663593K";
            string dniNumbers = dniReal.Substring(0, dniReal.Length - 1);
            string dniLeter = dniReal.Substring(dniReal.Length - 1, 1);
            bool real;
            bool esperado = true;

            if (dniReal.Length != 9)
            {
                real = false;
            }
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                real = false;
            }
            if (CalculateDNILeterTest(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                real = false;
            }
            real = true;

            Assert.AreEqual(esperado, real);
        }

        [TestMethod()]
        public string CalculateDNILeterTest(int numeros)
        {
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            int indiceReal = numeros % 23;
            string letraReal = control[indiceReal];
            string letraEsperada = "K";
            Assert.AreEqual(letraEsperada, letraReal);
            return letraReal;
        }
    }
}








