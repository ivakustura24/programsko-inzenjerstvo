using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija_clanova_2
{
    
    internal class Validator
    {
        public Validator() { }
        public bool ValidirajEmail (string emailAdresa)
        {
            if((emailAdresa.Contains("@")) && (emailAdresa.Contains("foi.hr")))
                return true;
            else
                return false;

        }
        public bool ValidirajLozinku (string lozinka)
        {
            if ((lozinka.Count() >= 6) && (lozinka.Count() <= 10))
                return true;
            else
                return false;

        }
    }
}
