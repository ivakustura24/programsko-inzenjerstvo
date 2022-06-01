using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Streaming_platforma_2
{
    public class Serija : IVideoZapis
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public KategorijaZapisa Kategorija { get; set; }
        public Serija (string naziv, string opis)
        {
            Naziv = naziv;
            Opis = opis;
        }
        public List<Sezona> SnimljeneSezone { get; set; }
        public int VratiRedniBroj()
        {
            return SnimljeneSezone.First().RedniBroj;
        }
        public string Reproduciraj()
        {
            Sezona sezona = SnimljeneSezone.First();
            string izlaz = $"Započeta reprodukcija serije {this.Naziv}, sezone {this.VratiRedniBroj()}, epizode {sezona.PrvaEpizodaSezone(this)} ";
            return izlaz;
        }
    }
}
