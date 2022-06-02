using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class Program
    {
       static GlasackaKutija glasackaKutija = new GlasackaKutija();
        static void Main(string[] args)
        {

            Console.WriteLine("APLIKACIJA ZA GLASANJE ");
            while (true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Unesite OIB:");
                string OIB = Console.ReadLine();
                Console.WriteLine("Unesite odabir [Z] = Za, [P]= Protiv, i [S] = Suzdržan:");
                string odabir = Console.ReadLine();
                glasackaKutija.Glasaj(OIB, odabir);
                glasackaKutija.DohvatiRezultateGlasovanja();
            }
               
            
        }
    }
}
