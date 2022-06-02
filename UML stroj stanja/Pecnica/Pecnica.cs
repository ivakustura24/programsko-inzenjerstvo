using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Oven
{
    class Pecnica
    {
        public string NazivPecnice { get; set; }
        public ProgramRada Program { get; set; }

        public PecnicaStanje Stanje { get; set; }
       
        public Pecnica()
        {
            NazivPecnice = "Electrolux 14232";
            Stanje = new PecnicaStanje();
        }

        public void Upali()
        {
            Stanje.IzvrsiPrijelaze(Dogadaj.STISNUT_GUMB_ON_OFF);
        }

        public void Ugasi()
        {
            Stanje.IzvrsiPrijelaze(Dogadaj.STISNUT_GUMB_ON_OFF);
        }

        public void OdaberiProgram(ProgramRada program)
        {
            Program = program;
            Stanje.IzvrsiPrijelaze(Dogadaj.ODABRAN_PROGRAM_PEČENJA);    
        }

        public void ZapocniPecenje()
        {
            Stanje.IzvrsiPrijelaze(Dogadaj.STISNUT_GUMB_START);
        }

        public void OznaciKaoZavrseno()
        {
            Stanje.IzvrsiPrijelaze(Dogadaj.ISTEKLO_VRIJEME_PEČENJA);
        }

        public void OhladiPecnicu()
        {
            Stanje.IzvrsiPrijelaze(Dogadaj.POTREBNO_OHLADITI_PEĆNICU);
        }
    }
}
