using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] polje = new string[7];
            int pobjeda=0, poraz=0, remi = 0;
            for (int i = 0; i < polje.Length; i++)
            {
                Console.WriteLine("Unesite utakmicu s rezultatima ");
                string unos = Console.ReadLine();
                string[] polje1 = unos.Split(':');
                char a = polje1[0].Last();
                char b= polje1[1].First();
                int rezultat1 = (int)Char.GetNumericValue(a);
                int rezultat2 = (int)Char.GetNumericValue(b);
                if (rezultat1 > rezultat2) pobjeda++;
                else if (rezultat2 > rezultat1) poraz++;
                else remi++;
            }
            Console.WriteLine($"Ukupno ostvarenih pobjeda: {pobjeda}");
            Console.WriteLine($"Ukupno ostvarenih poraza: {poraz}");
            Console.WriteLine($"Ukupno ostvarenih remija: {remi}");
            Console.ReadLine();
        }
    }
}
