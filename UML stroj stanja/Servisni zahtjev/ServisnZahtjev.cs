using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_ServisniZahtjev
{
    public class ServisniZahtjev
    {
        public string Opis { get; set; }
        public DateTime DatumIzrade { get; set; }
        public DateTime DatumZaprimanja { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZatvaranja { get; set; }
        public DateTime DatumOdbijanja { get; set; }

        public ZahtjevStanje Stanje { get; set; }

        public ServisniZahtjev()
        {
            Stanje = new ZahtjevStanje();
        }

        public void PodnesiZahtjev(string opis, DateTime datumIzrade)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.SVI_ELEMENTI_POPUNJENI);
            Opis = opis;
            DatumIzrade = datumIzrade;
        }

        public void ZaprimiZahtjev(DateTime datumZaprimanja)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.POTVRĐENI_PRIMITAK_ZAHTJEVI);
            DatumZaprimanja = DateTime.Now;
        }

        public void ZapocniServisiranje(DateTime datumPocetka)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.ZAHTJEV_DOŠAO_NA_RED);
            DatumPocetka = datumPocetka;
        }

        internal void ZatvoriZahtjev(DateTime datumDovrsetka)
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.POPRAVCI_IZVRŠENI);
            DatumZatvaranja = datumDovrsetka;
        }

        public void OdbijZahtjev()
        {
            Stanje.IzvrsiPrijelaz(Dogadaj.PREKRŠENI_UVJETI_GARANCIJE);
            DatumOdbijanja = DateTime.Now;
        }
    }
}
