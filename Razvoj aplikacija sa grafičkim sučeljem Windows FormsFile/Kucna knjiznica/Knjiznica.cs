using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kucna_knjiznica_2
{
    internal class Knjiznica
    {
        public List<Knjiga> PopisKnjiga;
        public Knjiznica()
        {
            PopisKnjiga = new List<Knjiga>();
            PopisKnjiga.Add(new Knjiga("Zlocin i kazna"));
            PopisKnjiga.Add(new Knjiga("Ana Karenjina"));
            PopisKnjiga.Add(new Knjiga("Rat i mir"));

        }
        public void Posudi(string ime, string naslov)
        {
            foreach (Knjiga k in PopisKnjiga)
            {
                if (k.Naslov == naslov)
                {
                    k.Dostupno = false;
                    k.Osoba = ime;
                }
            }
        }
    }
}
