using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_e_mail_računa
{
    internal class EmailGenerator
    {
        public string GenerirajEmail (string ime, string prezime)
        {
            string email = ime.ToLower() +"."+ prezime.ToLower()+ "@foi.hr";
            return email;
        }
        public string GenerirajSkraceniEmail (string ime, string prezime)
        {
            string _ime = ime.Substring(0, 1);
            string _prezime = prezime.Substring(0, 5);
            string skracenimail = _ime.ToLower()+"." + _prezime.ToLower()+"@foi.hr";
            return skracenimail;
        }
    }
}
