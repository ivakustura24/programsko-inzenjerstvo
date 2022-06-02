using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class Projekt
    {
        public string OpisTeme { get; set; }
        public string OznakaTima { get; set; }
        public DateTime DatumPredaje { get; set; }
        public DateTime DatumObrane { get; set; }

        public StanjeProjekta Stanje { get; set; }
        public Projekt()
        {
            Stanje = new StanjeProjekta();

        }

        public void ZabiljeziTemu(string opisTeme, string oznakaTima)
        {
            OpisTeme = opisTeme;
            OznakaTima = oznakaTima;
            Stanje.IzvrsiPrijelaz(Dogadaj.TIM_PRIJAVIO_TEMU);
        }

        public void PredajProjekt(DateTime datumPredaje)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.DOVRŠEN_PROJEKT);
            Stanje.IzvrsiPrijelaz(Dogadaj.PROJEKT_PROVJEREN);
            DatumPredaje = datumPredaje;
        }

        public void OdbijProjekt()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.PROJEKT_NE_ZADOVOLJAVA);
        }

        public void PrihvatiProjekt()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.PROJEKT_ZADOVOLJAVA);
        }

        public void ZakažiObranu(DateTime datumObrane)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.ODABRAN_TERMIN_OBRANE);
            DatumObrane = datumObrane;
        }

        public void OznačiKaoObranjen()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.USPJEŠNA_OBRANA);
        }
    }
}
