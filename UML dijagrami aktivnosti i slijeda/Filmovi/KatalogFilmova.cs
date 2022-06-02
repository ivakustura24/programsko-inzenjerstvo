using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Filmovi
{
    internal class KatalogFilmova
    {
        public List<Film> filmovi = new List<Film>()
        {
            new Film { ID = 1, Naziv = "Batman", Trajanje = 90 },
            new Film { ID = 2, Naziv = "Supeman", Trajanje = 85 },
            new Film { ID = 3, Naziv = "Spiderman", Trajanje = 98 },
            new Film { ID = 4, Naziv = "Ironman", Trajanje = 110 },
            new Film { ID = 5, Naziv = "Hulk", Trajanje = 115 }
        };
        public List <Film> DohvatiSveFilmove()
        {
            List <Film> sviFilmovi = new List<Film>();
            sviFilmovi = filmovi;
            
            return sviFilmovi;
        }
    }
}
