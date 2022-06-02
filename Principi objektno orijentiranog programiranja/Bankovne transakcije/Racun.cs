using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Racun
    {

        public string IBAN  {get; set;}
        public double Stanje {get; set;}

        public Racun()
        {

        }
        public Racun (string iban, double stanje)
        {
            IBAN = iban;
            Stanje = stanje;
        }
        
    }
}
