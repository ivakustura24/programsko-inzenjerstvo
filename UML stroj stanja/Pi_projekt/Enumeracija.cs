using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public enum Stanje
    {
        NijePrijavljenaTema,
        TemaPrijavljena,
        PredanProjekt,
        ProvjerenProjekt,
        PrihvaćenProjekt,
        ZakazanaObrana,
        ObranjenProjekt
    }
    public enum Dogadaj
    {
        TIM_PRIJAVIO_TEMU,
        DOVRŠEN_PROJEKT,
        PROJEKT_PROVJEREN,
        PROJEKT_NE_ZADOVOLJAVA,
        PROJEKT_ZADOVOLJAVA,
        ODABRAN_TERMIN_OBRANE,
        USPJEŠNA_OBRANA
    }


}
