using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_platforma_01
{
     class Film : VideoSadrzaj
    {
        public int Trajanje { get; set; }
        public Film(string naziv, string opis, VrstaSadrzaja vrsta): base(naziv, opis)
         
        {
         
            Vrsta = vrsta;
        }

        public string VratiInfo()
        {
            string informacija = $"{Naziv} {Opis},  {Vrsta}";
            return informacija;
        }

        
    }
}
