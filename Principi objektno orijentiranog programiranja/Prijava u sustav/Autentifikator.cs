using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava_u_sustav
{
    internal class Autentifikator
    {
        private List<Korisnik> listaKorisnika; 
        public Autentifikator()
        {
            listaKorisnika = new List<Korisnik>();
            listaKorisnika.Add(new Korisnik("pperic", "1111"));
            listaKorisnika.Add(new Korisnik("ikustura", "2404"));
            listaKorisnika.Add(new Korisnik("mcolle", "2807"));

        }
        private Korisnik DohvatiKorisnika (string korisnickoIme)
        {
            Korisnik trazeni = null;
            foreach (Korisnik k in listaKorisnika)
            {
                if(k.KorisnickoIme == korisnickoIme)
                {
                    trazeni = k;
                }
            }
            return trazeni;
        }
        public string PrijaviKorisnika (string korisnickoIme, string lozinka)
        {
            Korisnik prijava = DohvatiKorisnika(korisnickoIme);
            if (prijava != null && prijava.Lozinka== lozinka)
            {
                return "Uspješno prijavljen korisnik!";
            }
            else if (prijava!=null && prijava.Lozinka != lozinka)
            {
                return "Pogrešno upisana lozinka!";

            }
            else
            {
                return "Ne postoji korisnik sa navedenim korisničkim imenon!";
            }
        }
    }
}
