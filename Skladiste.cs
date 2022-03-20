using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Skladiste
    {
        private List<Proizvod> proizvodi;
        static Proizvod pro = new Proizvod();
        public Skladiste()
        {
            proizvodi = new List<Proizvod>();
        }
        public void DodajProizvod (Proizvod proizvod)
        {
            int i = 0;
            foreach (Proizvod p in proizvodi)
            {
                if (p.Naziv == proizvod.Naziv)
                {
                    Console.WriteLine("Proizvod već postoji!");
                    i++;
                }
            }
            if(i==0)
                proizvodi.Add(proizvod);

        }
        public void UkloniProizvod (Proizvod proizvod)
        {
            foreach (Proizvod p in proizvodi)
            {
                if (p == proizvod)
                    proizvodi.Remove(p);
            }
        }
        public Proizvod DohvatiProizvod (string naziv)
        {
            Proizvod proizvod = null;
            foreach (Proizvod p in proizvodi)
            {
                if (p.Naziv == naziv)
                    proizvod = p;
            }
            return proizvod;
        }
        public List<Proizvod> DohvatiSveProizvode()
        {
            List<Proizvod> list = new List<Proizvod>();
            foreach (Proizvod p in proizvodi)
            {
                list.Add(p);
            }
            return list;
        }
        public double IzracunajUkupnuVrijednostZaliha( )
        {
            double ukupno = 0;
            List<Proizvod> lista = DohvatiSveProizvode();
            foreach (Proizvod p in lista)
            {
                ukupno = ukupno + pro.IzracunajVrijednostZaliha(p.Stanje, p.Cijena);
            }
            return ukupno;
        }
    }
}
