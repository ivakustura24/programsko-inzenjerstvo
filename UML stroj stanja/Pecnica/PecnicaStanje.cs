using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Oven
{
    public class PecnicaStanje
    {
        public Stanje TrenutnoStanje { get; set; }
        public Dictionary<Prijelaz, Stanje> dozvoljeniPrijelaz;

        public PecnicaStanje()
        {
            TrenutnoStanje = Stanje.Ugašena;
            DefinirajDozvoljenePrijelaze();
            
        }
        public void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelaz = new Dictionary<Prijelaz,Stanje>();
            dozvoljeniPrijelaz.Add(new Prijelaz(Stanje.Ugašena, Dogadaj.STISNUT_GUMB_ON_OFF), Stanje.Upaljena);
            dozvoljeniPrijelaz.Add(new Prijelaz(Stanje.Upaljena, Dogadaj.STISNUT_GUMB_ON_OFF), Stanje.Ugašena);

            dozvoljeniPrijelaz.Add(new Prijelaz(Stanje.Upaljena, Dogadaj.ODABRAN_PROGRAM_PEČENJA), Stanje.ProgramOdabran);
            dozvoljeniPrijelaz.Add(new Prijelaz(Stanje.ProgramOdabran, Dogadaj.STISNUT_GUMB_START), Stanje.PečenjeZapočeto);

            dozvoljeniPrijelaz.Add(new Prijelaz(Stanje.PečenjeZapočeto, Dogadaj.ODABRAN_PROGRAM_PEČENJA), Stanje.ProgramOdabran);

            dozvoljeniPrijelaz.Add(new Prijelaz(Stanje.PečenjeZapočeto, Dogadaj.ISTEKLO_VRIJEME_PEČENJA), Stanje.PečenjeZavršilo);
            dozvoljeniPrijelaz.Add(new Prijelaz(Stanje.PečenjeZavršilo, Dogadaj.POTREBNO_OHLADITI_PEĆNICU), Stanje.HlađenjeGotovo);
            dozvoljeniPrijelaz.Add(new Prijelaz(Stanje.PečenjeZavršilo, Dogadaj.STISNUT_GUMB_ON_OFF), Stanje.Ugašena);
        }

        public void IzvrsiPrijelaze(Dogadaj dogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutnoStanje, dogadaj);
            Stanje odredisnoStanje;
            if(dozvoljeniPrijelaz.TryGetValue(prijelaz, out odredisnoStanje)== false)
            {
                throw new ApplicationException($"Prijelaz {TrenutnoStanje}-> {dogadaj} nije dozvoljen!");
            }
            TrenutnoStanje = odredisnoStanje;
        }
    }
}
