using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Dishwasher
{
    public class PerilicaStanje
    {
        public Stanje TrenutnoStanje { get; set; }
        public Dictionary<Prijelaz, Stanje> dozvoljeniPrijelazi;
        

        public PerilicaStanje()
        {
            TrenutnoStanje = Stanje.Ugašena;
            DefinirajDozvoljenePrijelaze();
        }
        public void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, Stanje>();

            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Ugašena, Događaj.STISNUT_GUMB_ON_OFF), Stanje.UMirovanju);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.UMirovanju, Događaj.STISNUT_GUMB_ON_OFF), Stanje.Ugašena);

            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.UMirovanju, Događaj.STISNUT_GUMB_ZA_PROGRAM), Stanje.OdabranProgram);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.OdabranProgram, Događaj.STISNUT_GUMB_START), Stanje.PranjeUToku);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PranjeUToku, Događaj.PRANJE_JE_ZAVRŠILO), Stanje.UMirovanju);

            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PranjeUToku, Događaj.STISNUT_GUMB_PAUSE_RESUME), Stanje.Pauzirano);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Pauzirano, Događaj.STISNUT_GUMB_PAUSE_RESUME), Stanje.PranjeUToku);
        }

        public void IzvrsiPrijelaz (Događaj dogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutnoStanje, dogadaj);
            Stanje odredisnoStanje;
            if(dozvoljeniPrijelazi.TryGetValue(prijelaz, out odredisnoStanje) == false)
            {
                throw new Exception($"Prijelaz {TrenutnoStanje} -> {dogadaj} nije dozvoljen!");
            }
            TrenutnoStanje = odredisnoStanje;
        }
    }
}
