using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_platforma_01
{
     class Serija:VideoSadrzaj
    {
        public List <Sezona> SnimljeneSezone { get; set; }
        public Serija (string naziv, string opis) : base (naziv, opis)
        {
            Naziv = naziv;
            Opis = opis;
        }
        public string VratiInfo()
        {
            int brojSezona = SnimljeneSezone.Count;
            string informacija = $"{brojSezona}";
            foreach(Sezona s in SnimljeneSezone)
            {
                informacija += $"{s.RedniBroj} ima ukupno {s.Epizode.Count()} epizoda";
            }
            return informacija;
        }
    }
}
