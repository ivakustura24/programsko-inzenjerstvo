using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    internal class Hotel
    {
        private List<Soba> sobe;
        public Hotel()
        {
            sobe = new List<Soba>();
            sobe.Add(new Soba("10A", 3, StatusSobe.Slobodna));
            sobe.Add(new Soba("10B", 1, StatusSobe.Rezervirana));
            sobe.Add(new Soba("11A", 2, StatusSobe.Slobodna));
            sobe.Add(new Soba("11B", 4, StatusSobe.Slobodna));
            sobe.Add(new Soba("12A", 5, StatusSobe.Slobodna));
            sobe.Add(new Soba("12B", 3, StatusSobe.Rezervirana));
            sobe.Add(new Soba("13A", 1, StatusSobe.Slobodna));
            sobe.Add(new Soba("13B", 3, StatusSobe.Rezervirana));
        }
        public List<Soba> PronadjiSobe (int brojOsoba)
        {
            List<Soba> SlobodneSobe = new List<Soba>();
            foreach (Soba s in sobe)
            {
                if (s.Kapacitet >= brojOsoba && s.Status == StatusSobe.Slobodna)
                    SlobodneSobe.Add(s);
            }
            return SlobodneSobe;
        }
        public void RezervirajSobu (string oznaka)
        {
            foreach (Soba s in sobe)
            {
                if (s.Oznaka == oznaka)
                {
                    s.Status = StatusSobe.Rezervirana;
                }
            }
        }

    }
}
