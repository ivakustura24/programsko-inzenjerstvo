using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RadniNalog
{
    public class RadniNalogStanje
    {

        public Stanje TrenutnoStanje { get; set; }
        public Dictionary<Prijelaz, Stanje> dozvoljeniPrijelazi;

        public RadniNalogStanje()
        {
            TrenutnoStanje = Stanje.Kreiran;
            DefinirajDozvoljenePrijelaze();
        }
        public void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, Stanje>();
            dozvoljeniPrijelazi.Add (new Prijelaz (Stanje.Kreiran, Dogadaj.SVE_STAVKE_DODANE), Stanje.Zaključan);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Zaključan, Dogadaj.ODUSTAJANJE_OD_PROIZVODNJE), Stanje.Otkazan);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Zaključan, Dogadaj.POTVRĐENA_PROIZVODNJA), Stanje.PredanUProizvodnju);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PredanUProizvodnju, Dogadaj.NALOG_PREUZET), Stanje.ZapočetaProizvodnja);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.ZapočetaProizvodnja, Dogadaj.PROIZVEDENE_SVE_STAVKE), Stanje.DovršenaProizvodnja);
        }

        public void IzvrsiPrijelaz (Dogadaj dogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutnoStanje, dogadaj);
            Stanje odredisniStatus;
            if (dozvoljeniPrijelazi.TryGetValue(prijelaz, out odredisniStatus)==false)
            {
                throw new ApplicationException($"Prijelaz {TrenutnoStanje} -> {dogadaj} nije dozvoljen!");
            }
            TrenutnoStanje = odredisniStatus;
        }

    }
}
