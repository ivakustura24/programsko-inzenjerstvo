using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Registracija
{
    internal class Generator
    {

        public string GenerirajEmail (string ime, string prezime)
        {
            
            return ime.First().ToString()+prezime.Substring(0,4)+"@foi.hr";
        }

        public int GenerirajLozinku()
        {
            Random random = new Random();
            int x = new Random().Next(1000, 9999);
         
            return x;
        }
    }
}
