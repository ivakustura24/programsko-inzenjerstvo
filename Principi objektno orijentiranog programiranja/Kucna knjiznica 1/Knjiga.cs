using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    enum StatusKnjige { Dostupno, NaPosudbi}
    internal class Knjiga
    {
        public string ISBN { get; set; }
        public string Naslov { get; set; }
        public StatusKnjige Status { get; set; }
        
        public Knjiga ( string isbn, string naslov, StatusKnjige status)
        {
            ISBN = isbn;    
            Naslov = naslov;
            Status = status;
        }
       
    }
}
