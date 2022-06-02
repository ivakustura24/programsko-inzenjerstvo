using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_e_mail_računa
{
    internal class LozinkaGenerator
    {
        public string GenerirajLozinku (string ime, string prezime)
        {
            string imepre = ime + prezime;
            int broj = imepre.Length;
            string lozinka = prezime.ToLower() + broj.ToString();
            return lozinka;

        }
    }
}
