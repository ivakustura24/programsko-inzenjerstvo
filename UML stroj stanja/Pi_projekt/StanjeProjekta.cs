using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class StanjeProjekta
    {

        public Stanje TrenutniStatus;
        public Dictionary<Prijelaz, Stanje> dozvoljeniPrijelazi;

        public StanjeProjekta()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, Stanje>();
            DefinirajDozvoljenePrijelaze();
        }
        public void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.NijePrijavljenaTema, Dogadaj.TIM_PRIJAVIO_TEMU), Stanje.TemaPrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.TemaPrijavljena, Dogadaj.DOVRŠEN_PROJEKT), Stanje.PredanProjekt);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PredanProjekt, Dogadaj.PROJEKT_PROVJEREN), Stanje.ProvjerenProjekt);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.ProvjerenProjekt, Dogadaj.PROJEKT_ZADOVOLJAVA), Stanje.PrihvaćenProjekt);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.ProvjerenProjekt, Dogadaj.PROJEKT_NE_ZADOVOLJAVA), Stanje.TemaPrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PrihvaćenProjekt, Dogadaj.ODABRAN_TERMIN_OBRANE), Stanje.ZakazanaObrana);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.ZakazanaObrana, Dogadaj.USPJEŠNA_OBRANA), Stanje.ObranjenProjekt);
        }

        public void IzvrsiPrijelaz (Dogadaj dogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutniStatus, dogadaj);
            Stanje OdredisniStatus; 
            if (dozvoljeniPrijelazi.TryGetValue(prijelaz, out OdredisniStatus)== false)
            {
                throw new Exception($"Prijelaz {TrenutniStatus}-> {dogadaj} nije dozvoljen");
            }
            TrenutniStatus = OdredisniStatus;
        }
    }
}
