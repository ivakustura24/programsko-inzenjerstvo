using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_PrepaidKartica
{
    internal class StanjeKartice
    {
        public Status TrenutniStatus { get; set; }
        private Dictionary<Prijelaz, Status> dozvoljeniPrijelazi;

        public StanjeKartice()
        {
            TrenutniStatus = Status.NijeAktivna;
            DefinirajDozvoljenePrijelaze();
        }
        public void DefinirajDozvoljenePrijelaze()
        {
           dozvoljeniPrijelazi = new Dictionary<Prijelaz, Status>();
           dozvoljeniPrijelazi.Add(new Prijelaz(Status.NijeAktivna, Dogadaj.PRODAJA_KARTICE), Status.Aktivna);
           dozvoljeniPrijelazi.Add(new Prijelaz(Status.Aktivna, Dogadaj.UPLACENA_SREDSTVA), Status.Aktivna);
           dozvoljeniPrijelazi.Add(new Prijelaz(Status.Aktivna, Dogadaj.IMA_SREDSTAVA), Status.Aktivna);
           dozvoljeniPrijelazi.Add(new Prijelaz(Status.Aktivna, Dogadaj.NEMA_SREDSTAVA), Status.NemaSredstava);
           dozvoljeniPrijelazi.Add(new Prijelaz(Status.NemaSredstava, Dogadaj.UPLACENA_SREDSTVA), Status.Aktivna);
        }

        public void IzvrsiPrijelaz (Dogadaj dogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutniStatus, dogadaj);
            Status odredisniStatus; 

            if (dozvoljeniPrijelazi.TryGetValue(prijelaz, out odredisniStatus) == false)
            {
                throw new ApplicationException ($"Prijelaz {TrenutniStatus} -> {dogadaj} nije dozvoljen!");
            }
            TrenutniStatus = odredisniStatus;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
