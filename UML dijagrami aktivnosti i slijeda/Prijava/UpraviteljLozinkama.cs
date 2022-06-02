using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Prijva
{
    internal class UpraviteljLozinkama
    {
        public List<string> lozinka = new List<string>()
        {
            "1;abc111",
            "2;abc222"
        };
        public string DohvatiLozinku (string IdKorisnika)
        {
            string trazenalozinka = null;
            foreach (string s in lozinka)
            {
                string[] polje = s.Split(';');
                if (polje[0] == IdKorisnika)
                {

                    trazenalozinka = polje[1];
                }
            }

            return trazenalozinka;
        }
    }
}
