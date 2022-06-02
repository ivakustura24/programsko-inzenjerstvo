using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrošnja_energije
{
    internal class Program
    {
        static Kuca kuca = new Kuca();
        static void Main(string[] args)
        {
            Console.WriteLine("Cijena potrosene engerije za proteklo razdoblje:");
            Console.WriteLine("------------------------------------------------------");
            foreach ( Brojilo b in kuca.Brojila)
            {
                Console.WriteLine($"Brojilo {b.Naziv} ({b.Tip}) = {kuca.IzracunajIznosZaBrojilo(b)}");
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"UKUPNO: {kuca.IzracunajIznosUkupno()} kn");
            Console.ReadLine();
        }
    }
}
