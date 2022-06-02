using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Registracija
{
    internal class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public int Lozinka { get; set; }
        public Korisnik (string ime, string prezime, string email, int lozinka)
        {
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Lozinka = lozinka;
        }
    }
}
