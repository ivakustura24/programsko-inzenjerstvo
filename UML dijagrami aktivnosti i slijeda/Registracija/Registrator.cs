using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Registracija
{
    internal class Registrator
    {

        public bool Registriraj (string ime , string prezime)
        {
            Generator generator = new Generator();
            string email = generator.GenerirajEmail(ime, prezime);
            int lozinka = generator.GenerirajLozinku();
            Korisnik novikorisnik = new Korisnik(ime, prezime, email, lozinka);
            bool dodan = Repozitorij.DodajKorisnika(novikorisnik);
            return dodan;
        }
    }
}
