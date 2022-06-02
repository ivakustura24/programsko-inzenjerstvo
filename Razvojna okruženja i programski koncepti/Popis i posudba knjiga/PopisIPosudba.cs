using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popis_i_posudba_knjiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dostupne = new List<string>();
            dostupne.Add("Prstenova druzina");
            dostupne.Add("Dvije kule");
            dostupne.Add("Rat i mir");
            dostupne.Add("Jadnici");
            List<string> posudene = new List<string>();
            posudene.Add("Povratak kralja");
            posudene.Add("Zlocin i kazna");
            string unos = "unos";
            while (unos != "#exit")
            {
                Console.WriteLine("Unesite naredbu:");
                unos = Console.ReadLine();
                if (unos == "#popis")
                {
                    foreach (string s in dostupne)
                    {
                        Console.WriteLine($"Naziv: {s}, Status: (dostupna)");
                    }
                    foreach (string s in posudene)
                    {
                        Console.WriteLine($"Naziv: {s}, Status: (nedostupna)");
                    }

                }
                else if (unos.Contains("#posudi"))
                {
                    string knjiga = unos.Substring(8);
                    Console.WriteLine($"Knjiga {knjiga} uspješno posuđena!");
                    dostupne.Remove(knjiga);
                    posudene.Add(knjiga);

                }
            }
            Console.ReadLine();
        }
    }
}
