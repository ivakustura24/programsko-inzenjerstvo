using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_ServisniZahtjev
{
    public class Prijelaz
    {
        public Stanje IzvorisniPrijelaz { get; set; }

        public Dogadaj Dogadaj { get; set; }    

        public Prijelaz(Stanje izvorisniPrijelaz, Dogadaj dogadaj)
        {
            IzvorisniPrijelaz = izvorisniPrijelaz;
            Dogadaj = dogadaj;

        }

        public override bool Equals(object obj)
        {
            return obj is Prijelaz prijelaz &&
                   IzvorisniPrijelaz == prijelaz.IzvorisniPrijelaz &&
                   Dogadaj == prijelaz.Dogadaj;
        }

        public override int GetHashCode()
        {
            int hashCode = 1271124474;
            hashCode = hashCode * -1521134295 + IzvorisniPrijelaz.GetHashCode();
            hashCode = hashCode * -1521134295 + Dogadaj.GetHashCode();
            return hashCode;
        }
    }
}
