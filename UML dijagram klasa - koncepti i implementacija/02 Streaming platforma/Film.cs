using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Streaming_platforma_2
{
    internal class Film : IVideoZapis
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public KategorijaZapisa Kategorija { get; set; }
        public int Trajanje { get; set; }

        public Film (string naziv, string opis): base()
        {
            Naziv = naziv;
            Opis = opis;
            
        }
        public string Reproduciraj()
        {
            string izlaz = $"Započeta je reprodukcija filma {this.Naziv}";
            return izlaz;
        }
    }
}
