using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Dishwasher
{
    public class Prijelaz
    {
        public Stanje IzvorisnoStanje { get; set; }
        public Događaj Dogadaj { get; set; }

        public Prijelaz (Stanje izvorisnoStanje, Događaj dogadaj)
        {
            IzvorisnoStanje = izvorisnoStanje;
            Dogadaj = dogadaj;
        }

        public override bool Equals(object obj)
        {
            return obj is Prijelaz prijelaz &&
                   IzvorisnoStanje == prijelaz.IzvorisnoStanje &&
                   Dogadaj == prijelaz.Dogadaj;
        }

        public override int GetHashCode()
        {
            int hashCode = -81101890;
            hashCode = hashCode * -1521134295 + IzvorisnoStanje.GetHashCode();
            hashCode = hashCode * -1521134295 + Dogadaj.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
