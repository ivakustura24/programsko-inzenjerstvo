using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Program
    {
        static Prvenstvo prvenstvo = new Prvenstvo();
        static void Main(string[] args)
        {
            Console.WriteLine("PRVENSTVO APP");
            int odabir;
          
            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("[1] Unesi reprezentaciju");
                Console.WriteLine("[2] Evidentiraj utakmicu");
                Console.WriteLine("[3] Ispiši tablicu rezultata");
                Console.WriteLine("[4] Ispiši bodovnu ljestvicu");
                Console.WriteLine("[0] Izlaz");
                Console.WriteLine("------------------------------");
                odabir = int.Parse(Console.ReadLine());
                string oznaka;
                string naziv;
                string domacin, gost;
                int domacinZgoditci, gostZgoditci;
                
                switch (odabir)
                {
                    case 1:
                        Console.Write("Unesite oznaku ");
                        oznaka = Console.ReadLine();
                        Console.Write("Unesite naziv reprezentacije ");
                        naziv = Console.ReadLine();
                        prvenstvo.DodajReprezentaciju(oznaka, naziv);
                        break;

                    case 2:
                        Console.Write("Unesite domacina ");
                        domacin = Console.ReadLine();
                        Console.Write("Unesite gosta ");
                        gost = Console.ReadLine();
                        Console.Write("Zgoditci domacina ");
                        domacinZgoditci = int.Parse(Console.ReadLine());
                        Console.Write("Zgoditci gosta ");
                        gostZgoditci = int.Parse(Console.ReadLine());
                        prvenstvo.DodajUtakmicu(domacin, gost, domacinZgoditci, gostZgoditci);
                        break;
                    case 3:
                        prvenstvo.GenerirajTablicuRezultata();
                        break;
                    case 4:
                        prvenstvo.GenerirajBodovnuLjestvicu();
                        break;
                }
            } while (odabir != 0);
        }
    }
}
