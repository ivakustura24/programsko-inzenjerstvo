using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Program
    {
        static Banka banka = new Banka();
        static Transakcija transakcija= new Transakcija();

        static void Main(string[] args)
        {
       
            Console.WriteLine("Unesite IBAN platitelja: ");
            string platitelj = Console.ReadLine();
            Console.WriteLine("Unesite IBAN primatelja: ");
            string primatelj = Console.ReadLine();
            Console.WriteLine("Unesite iznos plaćanja: ");
            int iznos= int.Parse(Console.ReadLine());
            Console.WriteLine("POTVRDA TRANSAKCIJE: ");
            Console.WriteLine("--------------------");
            transakcija = banka.IzvrsiPlacanje(platitelj, primatelj, iznos);
            Console.WriteLine($"Novo stanje računa {transakcija.Platitelj.IBAN} je {transakcija.Platitelj.Stanje}.");
            Console.WriteLine($"Novo stanje računa {transakcija.Primatelj.IBAN} je {transakcija.Primatelj.Stanje}.");
            Console.ReadLine(); 



        }
    }
}
