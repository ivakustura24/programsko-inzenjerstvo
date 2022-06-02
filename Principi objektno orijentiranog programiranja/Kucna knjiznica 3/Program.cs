using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Program
    {
        static Knjiznica knjiznica = new Knjiznica();
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime prezime osobe kojoj posudujemo knjigu: ");
            string osoba = Console.ReadLine();
            Console.WriteLine("Unesite ISBN knjige");
            string ISBN = Console.ReadLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----------POSUDBA------------");
            Console.WriteLine("------------------------------");
            knjiznica.PosudiKnjigu(osoba, ISBN);
            foreach (Posudba p in knjiznica.Posudbe)
            {
                if(p.Osoba == osoba && p.PosudjenaKnjiga.ISBN == ISBN)
                {
                    Console.WriteLine($"Osoba: {p.Osoba}");
                    Console.WriteLine($"ISBN knjige: {p.PosudjenaKnjiga.ISBN}");
                    Console.WriteLine($"Naslov knjige: {p.PosudjenaKnjiga.Naslov}");
                    Console.WriteLine($"Datum posudbe: {p.Datum}");
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
