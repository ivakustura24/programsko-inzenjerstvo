using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Streaming_platforma_2
{
     interface IVideoZapis
    {
        string Naziv { get; set; }
        string Opis { get; set; }
        KategorijaZapisa Kategorija { get; set; }

        string Reproduciraj();
    }
}
