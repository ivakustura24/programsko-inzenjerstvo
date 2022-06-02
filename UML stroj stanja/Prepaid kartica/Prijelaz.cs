using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    public class Prijelaz
    {

        public Status IzvorisniStatus { get; set; } 
        public Dogadaj Dogadaj { get; set; }

        public Prijelaz(Status izvorisniStatus, Dogadaj dogadaj)
        {
            IzvorisniStatus = izvorisniStatus;
            Dogadaj = dogadaj;
        }

        public override bool Equals(object obj)
        {
            return obj is Prijelaz prijelaz &&
                   IzvorisniStatus == prijelaz.IzvorisniStatus &&
                   Dogadaj == prijelaz.Dogadaj;
        }

        public override int GetHashCode()
        {
            int hashCode = -1716299155;
            hashCode = hashCode * -1521134295 + IzvorisniStatus.GetHashCode();
            hashCode = hashCode * -1521134295 + Dogadaj.GetHashCode();
            return hashCode;
        }

    
    }
}
