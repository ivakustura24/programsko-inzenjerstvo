using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RadniNalog
{
    public class RadniNalog
    {
        public string Opis { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumPredaje { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumDovrsetka { get; set; }
        public RadniNalogStanje Stanje { get; set; }

        public RadniNalog()
        {
            Stanje= new RadniNalogStanje();
        }
        public void ZakljucajNalog(string opis)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.SVE_STAVKE_DODANE);
            Opis = opis;
            DatumKreiranja = DateTime.Now;
        }

        public void PredajUProizvodnju(DateTime datumPredaje)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.POTVRĐENA_PROIZVODNJA);
            DatumPredaje = DateTime.Now;
        }

        public void ZapocniProizvodnju(DateTime datumPocetka)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.NALOG_PREUZET);
            DatumPocetka = datumPocetka;
        }

        internal void DovrsiProizvodnju(DateTime datumDovrsetka)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.PROIZVEDENE_SVE_STAVKE);
            DatumDovrsetka = datumDovrsetka;
        }

        public void OtkaziNalog()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.ODUSTAJANJE_OD_PROIZVODNJE);
        }
    }
}
