using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svjetsko_vrijeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gradovi = new List<string>
            {
                "Santiago;-4", "Salvador;-3",
                "London;+0", "Zagreb;+1",
                "Damask;+2", "Istanbul;+3"
            };
            DateTime trenutniDatumVrijeme = DateTime.UtcNow;
            DateTime rezultat;
            foreach (string s in gradovi)
            {
                string[] polje = s.Split(';');
                string operacija = polje[1].Substring(0, 1);
                string vrijeme = polje[1].Substring(1);
                double vrijeme1 = double.Parse(vrijeme);
                if ( operacija == "+")
                {
                    rezultat = trenutniDatumVrijeme.AddHours(vrijeme1);
                }
                else
                {
                    rezultat = trenutniDatumVrijeme.AddHours(-vrijeme1);
                }
                string rezultat1 = rezultat.ToShortTimeString();
                Console.WriteLine($"Trenutno vrijeme za {polje[0]} je: {rezultat1}");

            }
            Console.ReadLine();
        }
    }
}
