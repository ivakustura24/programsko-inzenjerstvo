using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    
    internal class KonverterValuta
    {
        public KonverterValuta()
        {

        }
        public double Konvertiraj (int iznos, double tecaj)
        {
            double rjesenje= iznos * (double)(1/tecaj);
            return rjesenje;
        }
    }
}
