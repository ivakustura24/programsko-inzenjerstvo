using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori_1
{

    internal class Program
    {
        static MeteoStanica stanica = new MeteoStanica();
        static void Main(string[] args)
        {
            Console.WriteLine("U kojoj mjernoj jedinici zelite izracun prosjecne temperature (C/K)?");
            string unos = Console.ReadLine();
            JedinicaMjere Mjera;
            if (unos == "C")
                Mjera = JedinicaMjere.Celzijus;
            else
                Mjera = JedinicaMjere.Kelvin;
            
            Console.WriteLine($"Prosjecna temperatura je: {stanica.DohvatiProsjecnuTemperaturu(Mjera)} ({Mjera})");
            Console.ReadLine();
        }
    }
}
