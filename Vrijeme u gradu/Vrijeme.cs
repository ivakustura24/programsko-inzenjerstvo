using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrijeme_u_gradu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite naziv grada: ");
            string unos = Console.ReadLine();
            string[] prvo = new string[]
                { "Santiago", "Salvador", 
                    "London", "Zagreb", 
                    "Damask", "Istanbul" 
                };
            string[] drugo = new string[]
            {
                "UTC-4", "UTC-3","UTC+0",
                "UTC+1", "UTC+2", "UTC+3"
            };
            DateTime datumVrijeme = DateTime.UtcNow;
            DateTime trenutnoVrijeme;
            int i = 0;
            foreach (string s in prvo)
            {
                if (s == unos)
                {
                   
                    string operacija = drugo[i].Substring(3);
                    char operacija1 = operacija.First();
                    string razlika = drugo[i].Substring(4);
                    double razlika1 = double.Parse(razlika);
                    if (operacija1 == '+')
                    {
                        trenutnoVrijeme = datumVrijeme.AddHours(razlika1);
                      
                    }
                    else
                    {
                        trenutnoVrijeme = datumVrijeme.AddHours(-razlika1);
                    }
                    string rezultat = trenutnoVrijeme.ToShortTimeString();
                    Console.WriteLine($"Trenutno vrijeme u gradu {unos} je: {rezultat}");
                }

                i++;
            }
            Console.ReadLine();
        }
    }
}
