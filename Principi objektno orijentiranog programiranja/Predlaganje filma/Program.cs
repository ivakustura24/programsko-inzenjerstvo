using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predlaganje_filma
{
    internal class Program
    {   
        static StreamingServis Servis = new StreamingServis();
        static Film film = new Film();
        static void Main(string[] args)
        {
            string odabir = "da";
            while (odabir == "da")
            {
                Console.WriteLine("Zelite li prijedlog filma (da/ne)?:");
                odabir = Console.ReadLine();
                if (odabir == "da")
                {
                    Console.WriteLine("Predlazemo sljedeci film: ");
                    Film novi = Servis.PredloziFilm();
                    string ispis = film.DohvatiInfo(novi);
                    Console.WriteLine(ispis);
                    Console.WriteLine("-----------------------------------");
                }


            }
            Console.ReadLine();
        }
    }
}
