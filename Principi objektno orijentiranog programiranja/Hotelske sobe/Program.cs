using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    internal class Program
    {
        static Hotel hotel = new Hotel();
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
                    string oznaka = polje[1];
                    if (naredba == "#pronadji")
                    {

                        int broj = int.Parse(polje[1]);
                        List<Soba> slobodne = new List<Soba>();
                        slobodne = hotel.PronadjiSobe(broj);
                        foreach (Soba s in slobodne)
                        {
                            Console.WriteLine($"Oznaka: {s.Oznaka}, Kapacitet: {s.Kapacitet}");
                        }
                        Console.WriteLine("________________________________");
                        slobodne.Clear();
                    }
                    else if (naredba == "#rezerviraj")
                    {
                        Console.WriteLine("________________________________");
                        hotel.RezervirajSobu(oznaka);
                    }
                }
            }while (naredba != "#exit");
            Console.ReadLine();
        }
    }
}
