using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj jedinica: ");
            string unos =Console.ReadLine();
            string[] polje = unos.Split();
            int a= int.Parse(polje[0]);
            Console.WriteLine("Unesite broj desetica: ");
            string unos1 = Console.ReadLine();
            string[] polje1 = unos1.Split();
            int b = int.Parse(polje1[0]);
            double c = ((b * 10) + a) * 2.1;
            Console.WriteLine($"Rezultat: {c}");
            Console.ReadLine();

        }
    }
}
