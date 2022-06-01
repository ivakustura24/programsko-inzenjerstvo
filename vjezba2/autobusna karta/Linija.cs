using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobusni_kolodvor
{
    internal class Linija
    {
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public int Udaljenost { get; set; }  

    public Linija (string polaziste, string odrediste, int udaljenost)
        {
            Polaziste = polaziste;
            Odrediste = odrediste;
            Udaljenost = udaljenost;
        }
    }
}
