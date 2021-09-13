using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TP2
{
    public static class OperacionesExtension
    {
        public static int Dividir(this int numero)
        {
               
            return numero / 0;

        }
        public static double Dividir(this double numero1, double numero2)
        {

            return numero1 / numero2;

        }
    }
}
