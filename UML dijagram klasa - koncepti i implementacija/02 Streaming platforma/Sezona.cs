using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Streaming_platforma_2
{
    public class Sezona
    {
        public int RedniBroj { get; set; }
        public List <Epizoda> Epizode { get; set; }

        public string PrvaEpizodaSezone (Serija serija)
        {
          string naziv = Epizode.First().Naziv;
            return naziv;
        }
    }
}
