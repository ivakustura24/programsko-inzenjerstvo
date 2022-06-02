using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_e_mail_računa
{
    internal class KorisnickiRacun
    {
        public string Ime { get; set; }
        public string Prezime  { get; set; }
        public string Email { get; set; }
        public string SkraceniEmail { get; set; }
        public string Lozinka { get; set; }

        public KorisnickiRacun() { }
        public KorisnickiRacun (string ime, string prezime, string email, string skraceniemail, string lozinka)
        {
            Ime = ime;
            Prezime = prezime;
            Email = email;
            SkraceniEmail = skraceniemail;
            Lozinka = lozinka;
        }
    }
}
