using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Streaming_servis
{
    internal class StreamingServis
    {
        KatalogFilmova katalogFilmova = new KatalogFilmova();
        public List <Film> DohvatiNeodgledaneFilmove()
        {
            
            List<Film> sviFilmovi = katalogFilmova.DohvatiSveFilmove();
            List<PogledaniFilm> pogledaniFilmovi = katalogFilmova.DohvatiPogledaneFilmove();
            List<Film> neodgledaniFilmovi = new List<Film>();
            foreach (Film f in sviFilmovi)
            {
                bool neodgledan = true;
                foreach (PogledaniFilm p in pogledaniFilmovi)
                {
                    if (f.Id == p.IdFilma)
                    {
                        neodgledan = false;
                    }
                }
                if(neodgledan == true)
                {
                    neodgledaniFilmovi.Add(f);
                }
            }
            return neodgledaniFilmovi;
        }
        
        public void PogledajFilm (Film odabraniFilm)
        {
            PogledaniFilm noviPogledaniFilm = new PogledaniFilm(odabraniFilm.Id);
            katalogFilmova.DodajPogledaniFilm(noviPogledaniFilm);
        }
    }
}
