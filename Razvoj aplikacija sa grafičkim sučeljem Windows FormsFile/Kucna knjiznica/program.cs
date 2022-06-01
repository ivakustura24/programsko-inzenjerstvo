using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kucna_knjiznica_2
{
    internal class Program
    {
        static Knjiznica knjiznica = new Knjiznica();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite naslov knjige koju posjedujete:");
            string knjiga = Console.ReadLine();
            Console.WriteLine("Unesite ime osobe kojoj posudujete knjigu:");
            string osoba = Console.ReadLine();
            knjiznica.Posudi(osoba,knjiga);
            foreach (Knjiga k in knjiznica.PopisKnjiga)
            {
                Console.WriteLine(k.DohvatiOpis());
            }
            Console.ReadLine();
        }
    }
}
