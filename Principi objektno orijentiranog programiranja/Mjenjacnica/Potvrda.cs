using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Potvrda
    {
        public DateTime Datum { get; set; }
        public int Iznos { get; set; }
        public double Tecaj { get; set; }
        public double Rjesenje { get; set; }
        public double Naknada { get; set; }
        public double Isplata { get; set; }
        public Potvrda() { }
        public Potvrda ( int iznos, double tecaj, double rjesenje, double naknada, double isplata)
        {
            Datum = DateTime.Now;
            Iznos = iznos;
            Tecaj = tecaj;
            Rjesenje = rjesenje;
            Naknada = naknada;
            Isplata = isplata;

        }
    }
}
