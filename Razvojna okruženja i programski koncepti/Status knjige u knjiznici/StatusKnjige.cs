using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status_knjige_u_knjižnici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naredba = "da";
            do
            {
                Console.WriteLine("Unesite naredbu: ");
                string unos = Console.ReadLine();
                string[] polje = unos.Split(' ');
                naredba = polje[0];
                if (naredba != "#exit")
                {
                    string knjiga = unos.Substring(8);
                    List<string> knjige = new List<string>
            {
                "Prstenova druzina;Dostupna",
                "Dvije kule;Dostupna",
                "Povratak kralja;Na posudbi",
                "Rat i mir;Dostupna",
                "Zlocin i kazna;Na posudbi",
                "Jadnici;Dostupna"
            };
                    int postoji = 0;
                    foreach (string s in knjige)
                    {
                        if (s.Contains(knjiga))
                        {
                            postoji++;
                            string[] polje1 = s.Split(';');
                            string dostupnost = polje1[1];
                            if (dostupnost == "Dostupna")
                                Console.WriteLine($"Knjiga {knjiga} je dostupna za posudbu!");
                            else
                                Console.WriteLine($"Knjiga {knjiga} je vec posudena!");

                        }

                    }
                    if (postoji == 0)
                    {
                        Console.WriteLine("U vasoj knjiznici ne postoji knjiga s tim nazivom!");
                    }
                }
            } while (naredba != "#exit");
            Console.ReadLine();
        }
    }
}
