using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R29_ACT3
{
    public static class Validacion
    {
        public static void ValidarCadena(string cadena, int max)
        {
            if (string.IsNullOrEmpty(cadena)) throw new ArgumentNullException("Cadena vacía");
            if (cadena.Length > max) throw new OverflowException($"{cadena} Supera el rango permitido (1.{max})");
        }
 

        public static void ValidarEdad(string cadena)
        {
            float num;

            num = Convert.ToSingle(cadena);

            if (num <= 0 || num > 100) throw new OverflowException($"{cadena} Supera el rango permitido");
        
        }
    }
}
