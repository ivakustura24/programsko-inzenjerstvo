using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predlaganje_filma
{
    enum Zanr { Komedija, Akcija, Horor}
    internal class Film
    {
        public string Naziv { get; set; }
        public Zanr Zanr { get; set; }
        public int Trajanje { get; set; }
        public bool VecGledan { get; set; }
        public Film() { }
        public Film (string naziv, Zanr zanr, int trajanje, bool vecGledan)
        {
            Naziv = naziv;
            Zanr = zanr;
            Trajanje = trajanje;
            VecGledan = vecGledan;
        }
        public string DohvatiInfo (Film f)
        {
            string ispis = f.Naziv + " (" + f.Zanr + ", " + f.Trajanje + ")";
            return ispis;
        }
    }
}
