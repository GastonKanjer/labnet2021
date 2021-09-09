using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP1
{
    public class Omnibus: TransportePublico
    {
        public Omnibus(int pasajeros):base(pasajeros)
        {

        }


        public override string Avanzar()
        {
            return string.Format("Soy un bondi y avanzo con {0} pasajeros", pasajeros);
        }

        public override string Detenerse()
        {
            return string.Format("Soy un bondi y me detengo con {0} pasajeros", pasajeros);

        }
    }
}
