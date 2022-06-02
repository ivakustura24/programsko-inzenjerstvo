using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Oven
{
    public enum Stanje
    {
        Ugašena,
        Upaljena, 
        ProgramOdabran,
        PečenjeZapočeto,
        PečenjeZavršilo,
        HlađenjeGotovo
    }
    public enum Dogadaj
    {
        STISNUT_GUMB_ON_OFF,
        ODABRAN_PROGRAM_PEČENJA,
        STISNUT_GUMB_START,
        ISTEKLO_VRIJEME_PEČENJA,
        POTREBNO_OHLADITI_PEĆNICU
    }
}
