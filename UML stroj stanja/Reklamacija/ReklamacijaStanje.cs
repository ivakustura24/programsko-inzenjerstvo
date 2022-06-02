using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Reklamacija
{
    public class ReklamacijaStanje
    {
        public Stanje TrenutnoStanje { get; set; }
        public Dictionary<Prijelaz, Stanje> dozvoljeniPrijelazi { get; set; }

        public ReklamacijaStanje()
        {
            TrenutnoStanje = Stanje.Podnesena;
            DefinirajDozvoljenePrijelaze();
        }

        private void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, Stanje>();
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Podnesena, Dogadaj.REKLAMACIJA_DOŠLA_NA_RED), Stanje.URazmatranju);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.URazmatranju, Dogadaj.REKLAMACIJA_OPRAVDANA), Stanje.Uvažena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.URazmatranju, Dogadaj.REKLAMACIJA_NEOPRAVDANA), Stanje.Odbijena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Odbijena, Dogadaj.PRISTIGLA_ZALBA_DA), Stanje.Podnesena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Odbijena, Dogadaj.PRISTIGLA_ZALBA_NE), Stanje.KonačnoOdbijena);
        }

        public void IzvrsiPrijelaz(Dogadaj dogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutnoStanje, dogadaj);
            Stanje odredisnoStanje;
            if(dozvoljeniPrijelazi.TryGetValue(prijelaz, out odredisnoStanje) == false)
            {
                throw new ApplicationException($"Prijelaz {TrenutnoStanje}-> {dogadaj} nije dozvoljen!");
            }
            TrenutnoStanje = odredisnoStanje;
        }
    }
}
