using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class StanjeProjekta
    {

        public Stanje TrenutnoStanje { get; set; }
        public Dictionary<Prijelaz, Stanje> dozvoljeniPrijelazi { get; set; }   

        public StanjeProjekta()
        {
            TrenutnoStanje = Stanje.TemaNijePrijavljena;
            DefinirajDozvoljenePrijelaze();
        }
        public void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, Stanje>();
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.TemaNijePrijavljena, Dogadaj.TIM_PRIJAVIO_TEMU), Stanje.TemaPrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.TemaPrijavljena, Dogadaj.TEMA_PROVJERENA), Stanje.ProvjeriTemu);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.ProvjeriTemu, Dogadaj.TEMA_NIJE_DOBRA), Stanje.TemaNijePrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.ProvjeriTemu, Dogadaj.TEMA_JE_U_REDU), Stanje.TemaPrihvaćena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.TemaPrihvaćena, Dogadaj.STIGAO_ROK_ZA_PRVU_FAZU), Stanje.PredanaPrvaFaza);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PredanaPrvaFaza, Dogadaj.STIGAO_FINALNI_ROK), Stanje.ProjektPredan);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.ProjektPredan, Dogadaj.ODRŽANA_OBRANA), Stanje.ProjektOcijenjen);
        }

        public void IzvrsiPrijelaz (Dogadaj dogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutnoStanje, dogadaj);
            Stanje odredisnoStanje;
            if(dozvoljeniPrijelazi.TryGetValue(prijelaz, out odredisnoStanje)== false)
            {
                throw new ApplicationException($"Prijelaz {TrenutnoStanje} -> {dogadaj} nije dozvoljen!");

            }
            TrenutnoStanje = odredisnoStanje;
        }
    }
}
