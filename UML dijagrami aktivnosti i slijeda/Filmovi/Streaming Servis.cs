using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Filmovi
{
    internal class Streaming_Servis
    {
        public List<Film> DohvatiZapoceteFilmove()
        {
            KatalogFilmova katalog = new KatalogFilmova();
            PovijestGledanja povijestGledanja = new PovijestGledanja();

            List<Film> sviFilmovi = katalog.DohvatiSveFilmove();
            List<PogledaniFilm> pogledaniFilmovi = povijestGledanja.DohvatiPogledaneFilmove();
            
            List<Film> zapocetiFilmovi = new List<Film>();
            
            foreach (Film f in sviFilmovi)
            {
                foreach (PogledaniFilm p in pogledaniFilmovi)
                {
                    if (f.ID == p.IdFilma && f.Trajanje > p.TrenutnaMinuta)
                    {
                        zapocetiFilmovi.Add(f);
                    }
                }
            }

            return zapocetiFilmovi;
        }
    }
}
