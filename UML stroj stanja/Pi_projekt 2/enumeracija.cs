using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public enum Stanje
    {
        TemaNijePrijavljena,
        TemaPrijavljena,
        ProvjeriTemu,
        TemaPrihvaćena,
        PredanaPrvaFaza,
        ProjektPredan,
        ProjektOcijenjen
    }
    public enum Dogadaj
    {
        TIM_PRIJAVIO_TEMU,
        TEMA_NIJE_DOBRA,
        TEMA_PROVJERENA,
        TEMA_JE_U_REDU,
        STIGAO_ROK_ZA_PRVU_FAZU,
        STIGAO_FINALNI_ROK,
        ODRŽANA_OBRANA
    }
}
