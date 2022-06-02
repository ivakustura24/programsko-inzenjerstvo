using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Nogometne_reprezentacije
{
    internal class Repozitorij
    {
        public List<Reprezentacija> reprezentacije = new List<Reprezentacija>()
        {
            new Reprezentacija {Oznaka = "HRV", Naziv="Hrvatska"},
            new Reprezentacija {Oznaka = "GER", Naziv="Njemačka"},
            new Reprezentacija {Oznaka = "FRA", Naziv="Francuska"}
        };
        public Reprezentacija DohvatiReprezentaciju(string oznakaDomacin)
        {
            Reprezentacija trazenaReprezentacija =null;
            foreach (Reprezentacija r in reprezentacije)
            {
                if(r.Oznaka == oznakaDomacin)
                {
                    trazenaReprezentacija = r;
                }
            }
            return trazenaReprezentacija;   
        }
    }
}
