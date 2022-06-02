using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Nogometne_reprezentacije
{
    internal class Susret
    {
        public Reprezentacija Domacin { get; set; }
        public int BrojPogodakaDomacin { get; set; }
        public Reprezentacija Gost { get; set; }
        public int BrojPogodakaGost { get; set; }

        public Susret(Reprezentacija domacin, int brojPogodakaDomacin, Reprezentacija gost, int brojPogodakaGost)
        {
            Domacin = domacin;
            BrojPogodakaDomacin = brojPogodakaDomacin;
            Gost = gost;
            BrojPogodakaGost = brojPogodakaGost;
        }
    }
}
