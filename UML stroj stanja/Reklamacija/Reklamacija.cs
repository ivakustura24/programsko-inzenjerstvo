using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Reklamacija
{
    public class Reklamacija
    {
        public int Id { get; set; }
        public string Opis { get; set; }

        public string Agent { get; private set; }
        public ReklamacijaStanje Stanje { get; set; }   

        public Reklamacija()
        {
            Stanje = new ReklamacijaStanje();
        }

        public void DodijeliAgenta(string agent)
        {
            Agent = agent;
            Stanje.IzvrsiPrijelaz(Dogadaj.REKLAMACIJA_DOŠLA_NA_RED);
        }

        public void Prihvati()
        {
            PosaljiObavijest("Vaša reklamacija je uvažena.");
            Stanje.IzvrsiPrijelaz(Dogadaj.REKLAMACIJA_OPRAVDANA);
        }

        private void PosaljiObavijest(string poruka)
        {
            //Šalje mail korisniku... NE TREBA IMPLEMENTIRATI
        }

        public void Odbij()
        {
            PosaljiObavijest("Vaša reklamacija je odbijena. Imate 3 dana za žalbu na tu odluku.");
            Stanje.IzvrsiPrijelaz(Dogadaj.REKLAMACIJA_NEOPRAVDANA);
        }

        public void KonačnoOdbij()
        {
            PosaljiObavijest("Vaša reklamacija je konačno odbijena. Više nemate mogućnost žalbe.");
            Stanje.IzvrsiPrijelaz(Dogadaj.PRISTIGLA_ZALBA_NE);
        }

        public void VratiUPostupak()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.PRISTIGLA_ZALBA_DA);
        }
    }
}
