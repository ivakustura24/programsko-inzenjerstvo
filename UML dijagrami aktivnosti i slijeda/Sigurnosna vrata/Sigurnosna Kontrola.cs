using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnosna_vrata
{
    internal class Sigurnosna_Kontrola
    {
        Repozitorij repozitorij = new Repozitorij();
        public bool OtvoriVrata(int brKartice, int pin, int brVrata)
        {
            Repozitorij repozitorij = new Repozitorij();
            bool prolaz = false;
            Korisnik korisnik = repozitorij.DohvatiKorisnika(brKartice, pin);
            Vrata vrata = repozitorij.DohvatiVrata(brVrata);
            if (korisnik.RazinaPrava >= vrata.RazinaPrava)
            {
                prolaz = true;
            }
            return prolaz;
        }
    }
}
