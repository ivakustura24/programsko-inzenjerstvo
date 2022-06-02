using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Filmovi
{
    internal class PovijestGledanja
    {
        public List<PogledaniFilm> PogledaniFilmovi = new List<PogledaniFilm>()
        {
            new PogledaniFilm {IdFilma =1, TrenutnaMinuta =90},
            new PogledaniFilm {IdFilma =2, TrenutnaMinuta =70},
            new PogledaniFilm {IdFilma =5, TrenutnaMinuta =55}
        };
        public List <PogledaniFilm> DohvatiPogledaneFilmove()
        {
            List <PogledaniFilm> pogledaniFilmovi = new List<PogledaniFilm>();
            pogledaniFilmovi = PogledaniFilmovi;
            return pogledaniFilmovi;
        }
    }
}
