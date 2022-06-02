using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Prijva
{
    internal class RepozitorijKorisnika
    {
        public List<Korisnik> Korisnici = new List<Korisnik>()
        {
            new Korisnik {Id = 1, KorisnickoIme = "pperic"},
            new Korisnik {Id = 2, KorisnickoIme = "ihorvat"}
        };
        public Korisnik DohvatiKorisnika(string korIme)
        {
            
            Korisnik pronadeniKorisnik = null;
            foreach (Korisnik k in Korisnici)
            {
                if (k.KorisnickoIme == korIme)
                {
                    pronadeniKorisnik = k;
                }
            }
            return pronadeniKorisnik;
        }
    }
}
