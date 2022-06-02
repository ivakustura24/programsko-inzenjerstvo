using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Dishwasher
{
    class Perilica
    {
        public string NazivPerilice { get; set; }
        public ProgramRada Program { get; set; }

        public PerilicaStanje Stanje { get; set; }
        public Perilica()
        {
            Stanje = new PerilicaStanje();  
            NazivPerilice = "BOSCH GDS3429";
        }

        public void Upali()
        {
            Stanje.IzvrsiPrijelaz(Događaj.STISNUT_GUMB_ON_OFF);
        }

        public void Ugasi()
        {
            Stanje.IzvrsiPrijelaz(Događaj.STISNUT_GUMB_ON_OFF);
        }

        public void OdaberiProgram(ProgramRada odabraniProgram)
        {
            Stanje.IzvrsiPrijelaz(Događaj.STISNUT_GUMB_ZA_PROGRAM);
            Program = odabraniProgram;
        }

        public void ZapocniPranje()
        {
            Stanje.IzvrsiPrijelaz(Događaj.STISNUT_GUMB_START);
        }

        public void OznaciPranjeZavrsilo()
        {
            Stanje.IzvrsiPrijelaz(Događaj.PRANJE_JE_ZAVRŠILO);
        }

        public void PauzirajPranje()
        {
            Stanje.IzvrsiPrijelaz(Događaj.STISNUT_GUMB_PAUSE_RESUME);
        }

        public void NastaviPranje()
        {
            Stanje.IzvrsiPrijelaz(Događaj.STISNUT_GUMB_PAUSE_RESUME);
        }
    }
}
