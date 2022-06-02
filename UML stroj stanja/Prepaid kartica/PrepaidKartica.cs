using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    public class PrepaidKartica
    {
        public string SerijskiBroj { get; set; }
        public double Iznos { get; set; }
        public Status TrenutniStatus { get; set; }
     
        
        public PrepaidKartica(string serijskiBroj)
        {
            SerijskiBroj = serijskiBroj;
        }

        public void Aktiviraj()
        {
            Iznos = 100;
            TrenutniStatus= Status.Aktivna;
        }

        public void Uplati(double iznosUplate)
        {
            
            Iznos += iznosUplate;
            TrenutniStatus = Status.Aktivna;
        }

        internal void Isplati(double iznosIsplate)
        {
            if(iznosIsplate > Iznos)
            {
                TrenutniStatus = Status.NemaSredstava;
                throw new ApplicationException("Nedovoljan iznos na računu!");
               
            }
            else
            {
                Iznos -= iznosIsplate;
                TrenutniStatus = Status.Aktivna;
            }
         
        }
    }
}
