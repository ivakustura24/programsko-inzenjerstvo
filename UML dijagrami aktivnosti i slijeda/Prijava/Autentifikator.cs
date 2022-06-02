using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Prijva
{
    internal class Autentifikator
    {
        public bool PrijaviKorisnika (string IdKorisnika, string lozinka)
        {
            UpraviteljLozinkama upraviteljLozinkama = new UpraviteljLozinkama();
            string dohvacenaLozinka = upraviteljLozinkama.DohvatiLozinku(IdKorisnika);
            if (dohvacenaLozinka == lozinka)
            {
                return true;
            }
            else
                return false;
        }
    }
}
