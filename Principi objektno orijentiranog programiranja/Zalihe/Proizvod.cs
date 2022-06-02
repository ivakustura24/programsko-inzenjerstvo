using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Proizvod
    {
        static Skladiste skladiste = new Skladiste();
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public int Stanje { get; set; }
        public Proizvod() { }

        public Proizvod (string naziv, double cijena, int stanje)
        {
            Naziv = naziv;
            Cijena = cijena;
            Stanje = stanje;
        }

        public double IzracunajVrijednostZaliha (int stanje, double cijena)
        {
            double vrijednost = stanje * cijena;
            return vrijednost;
        }
        public void DodajNaStanje (int kolicina)
        {
            if (kolicina <= 0)
                Console.WriteLine("Pogrešno unesena količina");
            else
            {
                Stanje = Stanje + kolicina;
                Console.WriteLine("Količina uspješno unesena");
            }
        }
        public void OduzmiSaStanja (int kolicina)
        {
            if (kolicina <= 0)
                Console.WriteLine("Nije moguće oduzeti negativnu količinu!");
            else if (Stanje - kolicina <= 0)
                Console.WriteLine("Ne postoji dovoljno robe na skladištu!");

            else
            {
               Stanje= Stanje - kolicina;
                Console.WriteLine("Uspješno promijenjeno stanje proizvoda");
            }
                

        }
    }
}
