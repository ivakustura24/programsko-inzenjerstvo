using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Posudba
    {
        public string Osoba { get; set; }
        public Knjiga PosudjenaKnjiga { get; set; }

        public DateTime Datum { get; set; }
        public Posudba(string osoba, Knjiga posudjenaKnjiga)
        {
            Osoba = osoba;
            PosudjenaKnjiga = posudjenaKnjiga;
            Datum = DateTime.Now;
               
        }
    }
}
