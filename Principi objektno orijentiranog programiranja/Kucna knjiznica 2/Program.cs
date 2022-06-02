using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kućna_knjižnica_2
{
    internal class Program
    {
        static Knjiznica knjiznica = new Knjiznica();
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite naslov knjige koju posudujete: ");
            string posudba = Console.ReadLine();
            Console.WriteLine("Unesite ime osobe kojoj posudujete knjigu:");
            string osoba = Console.ReadLine();
            knjiznica.Posudi(posudba, osoba);
            foreach (Knjiga k in knjiznica.PopisKnjiga)
            {
                Console.WriteLine(k.DohvatiOpis());
            }
            Console.ReadLine();
            
            

        }
    }
}
