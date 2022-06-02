using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    public enum Status
    {
        NijeAktivna,
        NemaSredstava,
        Aktivna
    }
    public enum Dogadaj
    {
        PRODAJA_KARTICE,
        UPLACENA_SREDSTVA,
        NEMA_SREDSTAVA,
        IMA_SREDSTAVA

    }
}
