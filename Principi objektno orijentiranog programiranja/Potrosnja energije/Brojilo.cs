using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrošnja_energije
{
    enum TipBrojila { Voda, Struja, Plin}
    internal class Brojilo
    {
        public string Naziv { get; set; }
        public TipBrojila Tip { get; set; }
        private double Stanje { get; set; }
        private double ZadnjeOcitanje {get; set; }
        public Brojilo() { }
        public Brojilo (string naziv, TipBrojila tip, double stanje, double zadnjeOcitanje)
        {
            Naziv = naziv;
            Tip = tip;
            Stanje = stanje;
            ZadnjeOcitanje = zadnjeOcitanje;
        }
        public double OcitajPotrosnju(Brojilo b)
        {
            double potrosnja = b.Stanje - b.ZadnjeOcitanje;
            return potrosnja;
        }
        
    }
}
