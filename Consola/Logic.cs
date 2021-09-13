using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TP2
{
    public class Logic
    {
        public static void Excepcion(int? nulo, int nro)
        {
            int operacion = nulo.Value * nro;
        }
    }
}
