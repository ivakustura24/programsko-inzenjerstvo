using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Reklamacija
{
    public enum Stanje
    {
        Podnesena,
        URazmatranju,
        Uvažena,
        Odbijena,
        KonačnoOdbijena
    }
    public enum Dogadaj
    {
        REKLAMACIJA_DOŠLA_NA_RED,
        REKLAMACIJA_OPRAVDANA,
        REKLAMACIJA_NEOPRAVDANA,
        PRISTIGLA_ZALBA_DA,
        PRISTIGLA_ZALBA_NE
    }
}
