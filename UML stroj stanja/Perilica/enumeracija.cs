using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Dishwasher
{
   
    public enum Stanje
    {
        Ugašena,
        UMirovanju,
        OdabranProgram,
        PranjeUToku,
        Pauzirano
    }
    public enum Događaj 
    {
        STISNUT_GUMB_ON_OFF,
        PRANJE_JE_ZAVRŠILO,
        STISNUT_GUMB_ZA_PROGRAM,
        STISNUT_GUMB_START,
        STISNUT_GUMB_PAUSE_RESUME
    }
}
