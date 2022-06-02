using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_e_mail_računa
{
    internal class EmailServer
    {
        static EmailGenerator Generator = new EmailGenerator();
        static LozinkaGenerator Lozinka = new LozinkaGenerator();
        public KorisnickiRacun KreirajKorisnickiRacun (string ime, string prezime)
        {
            KorisnickiRacun k = new KorisnickiRacun();
            k.Ime = ime;
            k.Prezime = prezime;
            k.Email = Generator.GenerirajEmail(ime, prezime);
            k.SkraceniEmail = Generator.GenerirajSkraceniEmail(ime, prezime);
            k.Lozinka = Lozinka.GenerirajLozinku(ime, prezime);
            return  k;
        }
    }
}
