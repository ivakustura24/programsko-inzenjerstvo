using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Registracija
{
    internal static class Repozitorij
    {
        public static  List<Korisnik> Korisnici { get; set; } = new List<Korisnik>();
        public static bool DodajKorisnika (Korisnik NoviKorisnik)
        {
            bool dodan = true;
            foreach (Korisnik k in Korisnici)
            {
                if (k.Ime == NoviKorisnik.Ime && k.Prezime ==NoviKorisnik.Prezime && k.Email==NoviKorisnik.Email)
                {
                    dodan = false;
                   
                }
            }
            if (dodan == false)
                return dodan;
            else
            {
                Korisnici.Add(NoviKorisnik);
                return dodan;
            }
          
        }


    }
}
