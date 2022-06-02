using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija_clanova_2
{
    
    internal class Program
    {
        static Registrator registrator = new Registrator();
        static void Main(string[] args)
        {
            Console.WriteLine("REGISTRACIJA ČLANA");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Unesite email korisnika:");
            string email = Console.ReadLine();
            Console.WriteLine("Unesite željenu lozinku:");
            string lozinka = Console.ReadLine();
            Console.WriteLine("----------------------------------------");
            registrator.RegistrirajClana(email, lozinka);
            Console.ReadLine();
        }
    }
}
