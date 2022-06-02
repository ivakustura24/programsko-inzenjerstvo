using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava_u_sustav
{
    internal class Program
    {
        static Autentifikator autentifikator = new Autentifikator();
        static void Main(string[] args)
        {
            Console.WriteLine("PRIJAVA U SUSTAV");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Korisničko ime: ");
            string korisnickoIme = Console.ReadLine();
            Console.WriteLine("Lozinka:");
            string lozinka = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine(autentifikator.PrijaviKorisnika(korisnickoIme, lozinka));
            
            Console.ReadLine();
        }
    }
}
