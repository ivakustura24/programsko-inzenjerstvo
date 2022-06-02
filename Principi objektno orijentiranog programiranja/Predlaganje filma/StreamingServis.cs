using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predlaganje_filma
{
    
    internal class StreamingServis
    {
        static Film filmm = new Film();
        public List<Film> Filmovi; 
        public StreamingServis()
        {
            Filmovi = new List<Film>();
            Filmovi.Add(new Film("Film 1", Zanr.Komedija, 88, false));
            Filmovi.Add(new Film("Film 2", Zanr.Akcija, 95, false));
            Filmovi.Add(new Film("Film 3", Zanr.Horor, 70, true));
            Filmovi.Add(new Film("Film 4", Zanr.Komedija, 120, false));
            Filmovi.Add(new Film("Film 5", Zanr.Akcija, 110, true));
            Filmovi.Add(new Film("Film 6", Zanr.Horor, 99, false));
            Filmovi.Add(new Film("Film 7", Zanr.Komedija, 75, false));
            Filmovi.Add(new Film("Film 8", Zanr.Akcija, 80, false));
            Filmovi.Add(new Film("Film 9", Zanr.Horor, 81, false));
            Filmovi.Add(new Film("Film 10", Zanr.Komedija, 99, true));

        }

        private List<Film> DohvatiFilmoveKojeNisamGledao()
        {
            List<Film> nepogledani = new List<Film>();
            foreach ( Film f in Filmovi)
            {
                if (f.VecGledan == false)
                    nepogledani.Add(f);
            }
            return nepogledani;
        }
        public Film PredloziFilm ()
        {
            Film prijedlog = null;
            List<Film> nepregledani = DohvatiFilmoveKojeNisamGledao();
            int duljina = nepregledani.Count();
            Random rnd = new Random();
            int index = rnd.Next(duljina);
            prijedlog = nepregledani[index];
            
            return prijedlog;
        }
    }
}
