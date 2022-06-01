using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobusni_kolodvor
{
    internal class Program
    {
        static AutobusniKolodvor autobusniKolodvor = new AutobusniKolodvor();
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite polaziste,odrediste i tip karte: ");
            string unos = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            string[] korisnikovUnos = unos.Split(' ');
            double iznos = autobusniKolodvor.KupiKartu(korisnikovUnos[0], korisnikovUnos[1], korisnikovUnos[2]);
            Console.WriteLine($"Cijena za kartu tipa {korisnikovUnos[2]},na relaciji {korisnikovUnos[0]} - {korisnikovUnos[1]} iznosi {iznos} kn!");
            Console.ReadLine();
        }
    }
}
