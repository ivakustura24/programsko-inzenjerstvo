using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava_u_sustav
{
    internal class Korisnik
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public Korisnik( string korisnickoIme, string lozinka)
        {
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
        }
    }
}
