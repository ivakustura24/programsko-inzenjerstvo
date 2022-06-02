using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_ServisniZahtjev
{
    public enum Stanje
    {
        UIzradi,
        Podnesen,
        Odbijen,
        Zaprimljen,
        UPostupku,
        ZahtjevZatvoren
    }
    public enum Dogadaj
    {
        SVI_ELEMENTI_POPUNJENI,
        POTVRĐENI_PRIMITAK_ZAHTJEVI,
        PREKRŠENI_UVJETI_GARANCIJE,
        ZAHTJEV_DOŠAO_NA_RED,
        POPRAVCI_IZVRŠENI
    }
}
