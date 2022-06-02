using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Tecaj
    {
        public string _valuta { get; set; }
        public double _tecaj { get; set; }

        public Tecaj()
        {

        }
        public Tecaj (string valuta, double tecaj)
        {
            _valuta = valuta;
            _tecaj = tecaj;
        }

    }
}
