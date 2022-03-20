using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Utakmica
    {
        public Reprezentacija Domacin { get; set; }
        public Reprezentacija Gost { get; set; }
        public int BodoviDomacin { get; set; }
        public int BodoviGost { get; set; }

        public Utakmica() { }
        public Utakmica (Reprezentacija domacin, Reprezentacija gost, int bodoviDomacin,int bodoviGost)
        {
            Domacin = domacin;
            Gost = gost;
            BodoviDomacin = bodoviDomacin;
            BodoviGost = bodoviGost;
        }
        public string GenerirajIspis (Utakmica utakmica)
        {
            string ispis = utakmica.Domacin.Oznaka +" "+utakmica.BodoviDomacin+ ":" + utakmica.BodoviGost + " " + utakmica.Gost.Oznaka ;
            return ispis;
        }
    }
}
