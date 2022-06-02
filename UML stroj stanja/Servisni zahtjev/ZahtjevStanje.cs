using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_ServisniZahtjev
{
    public class ZahtjevStanje
    {

        public Stanje TrenutnoStanje { get; set; }
        public Dictionary<Prijelaz, Stanje> dozvoljeniPrijelazi;

        public ZahtjevStanje()
        {
            TrenutnoStanje = Stanje.UIzradi;
            DefinirajDozvoljenePrijelaze();
        }

        public void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi =new Dictionary<Prijelaz, Stanje>();
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.UIzradi, Dogadaj.SVI_ELEMENTI_POPUNJENI),Stanje.Podnesen);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Podnesen, Dogadaj.POTVRĐENI_PRIMITAK_ZAHTJEVI), Stanje.Zaprimljen);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Zaprimljen, Dogadaj.ZAHTJEV_DOŠAO_NA_RED), Stanje.UPostupku);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.UPostupku, Dogadaj.POPRAVCI_IZVRŠENI), Stanje.ZahtjevZatvoren);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Podnesen, Dogadaj.PREKRŠENI_UVJETI_GARANCIJE), Stanje.Odbijen);
        } 

        public void IzvrsiPrijelaz(Dogadaj dogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutnoStanje, dogadaj);
            Stanje odredisnoStanje;
            if(dozvoljeniPrijelazi.TryGetValue(prijelaz, out odredisnoStanje) == false)
            {
                throw new ApplicationException($"Prijelaz {TrenutnoStanje} -> {dogadaj} nije dozvoljeno!");
            }
            TrenutnoStanje= odredisnoStanje;
        }
    }
}
