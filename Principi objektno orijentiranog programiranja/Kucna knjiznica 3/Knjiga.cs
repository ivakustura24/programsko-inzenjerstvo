using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Knjiga
    {
        public string ISBN { get; set; }
        public string Naslov { get; set; }
        public Knjiga()
        {

        }
        public Knjiga(string isbn, string naslov)
        {
            ISBN = isbn;
            Naslov = naslov;
        }
    }
}
