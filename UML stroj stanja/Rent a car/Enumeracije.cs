using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
   public enum Status
    {
        UKvaru, 
        Raspoloživ,
        Rezerviran,
        UUporabi,
        NaPregledu
    }
    public enum Dogadaj
    {
        KVAR,
        POPRAVLJEN_KVAR,
        KLIJENT_ZATRAZIO_VOZILO,
        KLIJENT_STIGAO_PO_AUTO,
        VOZILO_SPREMNO,
        KLIJENT_VRACA_AUTO
    }
}
