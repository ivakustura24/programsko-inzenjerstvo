using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnosna_vrata
{
    internal class Repozitorij
    {
        private List<Korisnik> Korisnici = new List<Korisnik>()
        {
            new Korisnik(10001,1234,1) {BrojKartice =10001, PIN = 1234, RazinaPrava = 1},
            new Korisnik(10001,1234,1) {BrojKartice =10002, PIN = 0000, RazinaPrava = 2},
            new Korisnik(10001,1234,1) {BrojKartice =10003, PIN = 9999, RazinaPrava = 2},


        };

        private List<Vrata> SvaVrata = new List<Vrata>()
        {
            new Vrata (501,1) {BrojVrata=501, RazinaPrava=1},
            new Vrata (501,1) {BrojVrata=502, RazinaPrava=2},
            new Vrata (501,1) {BrojVrata=503, RazinaPrava=2},
        };


        public Korisnik DohvatiKorisnika (int brKartice, int pin)
        {
            Korisnik trazeni = null;
            foreach(Korisnik k in Korisnici)
            {
                if (k.BrojKartice == brKartice && k.PIN == pin)
                    trazeni = k;
            }
            return trazeni;
        }

        public Vrata DohvatiVrata (int brVrata)
        {
             Vrata trazenaVrata = null;
             foreach (Vrata v in SvaVrata)
            {
                if (v.BrojVrata == brVrata)
                    trazenaVrata = v;
            }
            return trazenaVrata;
        }
    }
}
