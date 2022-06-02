using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Streaming_servis
{
    internal class PogledaniFilm
    {
        public int IdFilma { get; set; }
        public DateTime DatumGledanja { get; set; }

        public PogledaniFilm (int idFilma)
        {
            IdFilma = idFilma;
            DatumGledanja = DateTime.Now;
        }
    }
}
