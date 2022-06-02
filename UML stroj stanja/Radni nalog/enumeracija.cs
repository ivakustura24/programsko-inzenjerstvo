using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RadniNalog
{
   public enum Stanje
    {
        Kreiran,
        Zaključan,
        PredanUProizvodnju,
        Otkazan,
        ZapočetaProizvodnja,
        DovršenaProizvodnja
    }
    public enum Dogadaj
    {
        SVE_STAVKE_DODANE,
        ODUSTAJANJE_OD_PROIZVODNJE,
        POTVRĐENA_PROIZVODNJA,
        NALOG_PREUZET,
        PROIZVEDENE_SVE_STAVKE
    }
}
