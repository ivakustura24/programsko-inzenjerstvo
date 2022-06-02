using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiraciLib;

namespace _10_Glasanje
{
    internal class Glasanje
    {
        PopisBiraca popisBiraca = new PopisBiraca();
        List<string> Glasovali { get; set; } = new List<string>();

        public int Za { get; set; } = 0;
        public int Protiv { get; set; } = 0;
        public int Suzdrzan { get; set; } = 0;
        public bool MozeGlasati (string oib)
        {
            bool naPopisu = popisBiraca.PostojiBirac(oib);
            bool NijeGlasovao = NijeGlasao(oib);
            if (naPopisu == true && NijeGlasovao == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private bool NijeGlasao (string oib)
        {
            foreach (string s in Glasovali)
            {
                if (s == oib)
                    return false;
            }
            return true;
        }

        public void Glasaj (string oib, string opcija)
        {
            Glasovali.Add(oib);
            if (opcija == "ZA")
            {
                Za++;
            }
            else if (opcija == "PROTIV")
            {
                Protiv++;
            }
            else
            {
                Suzdrzan++;
            }
        }
    }
}
