using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Program
    { 
        static Proizvod proizvod = new Proizvod();
        static Skladiste skladiste = new Skladiste();
        static void Main(string[] args)
        {
            int odabir = 0;
            do
            {
                List<Proizvod> SviProizvodi = new List<Proizvod>();
                Console.WriteLine("Odaberite");
                Console.WriteLine("[1] Dodaj proizvod na skladište");
                Console.WriteLine("[2] Povećaj količinu proizvoda");
                Console.WriteLine("[3] Smanji količinu proizvoda");
                Console.WriteLine("[4] Ispiši stanje skladišta");
                Proizvod pro = new Proizvod();
                odabir = int.Parse(Console.ReadLine());
                if(odabir != 5)
                {
                    switch (odabir)
                    {
                        case 1:
                            Console.WriteLine("Unesite naziv proizvoda ");
                            pro.Naziv = Console.ReadLine();
                            Console.WriteLine("Unesite cijenu proizvoda ");
                            pro.Cijena = double.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite stanje proizvoda ");
                            pro.Stanje = int.Parse(Console.ReadLine());
                            skladiste.DodajProizvod(pro);
                            break;
                        case 2:
                            Console.WriteLine("Unesite naziv proizvoda ");
                            string naziv = Console.ReadLine();
                            Proizvod povecaniProizvod=skladiste.DohvatiProizvod(naziv);
                            Console.WriteLine("Unesite količinu proizvoda ");
                            int kolicina = int.Parse((Console.ReadLine()));
                            povecaniProizvod.DodajNaStanje(kolicina);
                            break;
                        case 3:
                            Console.WriteLine("Unesite naziv proizvoda ");
                            string snaziv = Console.ReadLine();
                            Proizvod smanjeniProizvod = skladiste.DohvatiProizvod(snaziv);
                            Console.WriteLine("Unesite količinu za koju želite smanjiti stanje");
                            int kol = int.Parse((Console.ReadLine()));
                            smanjeniProizvod.OduzmiSaStanja(kol);
                            break;

                        case 4:
                            SviProizvodi = skladiste.DohvatiSveProizvode();
                            double ukupno = skladiste.IzracunajUkupnuVrijednostZaliha();
                            foreach (Proizvod p in SviProizvodi)
                            {
                                Console.WriteLine($"Proizvod: {p.Naziv}, Cijena: {p.Cijena}, Stanje: {p.Stanje}");
                            }
                            Console.WriteLine($"Ukupna vrijednost svih proizvoda je {ukupno} ");
                            break;
                    }

                }
            } while (odabir != 5);
            Console.ReadLine();
        }
    }
}
