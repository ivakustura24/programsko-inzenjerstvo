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
        public DateTime DatumPredajePrveFaze { get; set; }
        public DateTime DatumPredajeCijelogProjekta { get; set; }
        public int BrojBodova { get; set; }

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

        public void PredajPrvuFazu(DateTime datumPredaje)
        {
            DatumPredajePrveFaze = datumPredaje;
            Stanje.IzvrsiPrijelaz(Dogadaj.STIGAO_ROK_ZA_PRVU_FAZU);
        }

        public void OdbijTemu()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.TEMA_PROVJERENA);
            Stanje.IzvrsiPrijelaz(Dogadaj.TEMA_NIJE_DOBRA);
        }

        public void PrihvatiTemu()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.TEMA_PROVJERENA);
            Stanje.IzvrsiPrijelaz(Dogadaj.TEMA_JE_U_REDU);
        }

        public void PredajCijeliProjekt(DateTime datumObrane)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.STIGAO_FINALNI_ROK);
            DatumPredajeCijelogProjekta = datumObrane;
        }

        public void OcijeniProjekt(int brojBodova)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.ODRŽANA_OBRANA);
            BrojBodova = brojBodova;
        }
    }
}
