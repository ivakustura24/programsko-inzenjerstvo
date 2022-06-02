using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbornik_i_sortiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            List<string> lista = new List<string>();
            while (a != 4) {
                Console.WriteLine("Izbornik ");
                Console.WriteLine("1.Unos podataka ");
                Console.WriteLine("2.Sortiranje");
                Console.WriteLine("3.Ispis ");
                Console.WriteLine("4.Izlaz ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                       
                        Console.Write("Unesite grad ");
                        lista.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Sortiranje");
                        Console.WriteLine("1.uzlazno sortiranje ");
                        Console.WriteLine("2.silazno sortiranje ");
                        string unos1 = Console.ReadLine();
                        int b = int.Parse(unos1);
                        if (b == 1)
                        {
                            lista.Sort();
                            lista.Reverse();
                        }
                        else
                        {
                            lista.Sort();
                        }
                        break;
                    case 3:
                        foreach (string s in lista)
                            Console.WriteLine(s);
                        break;
                 
                }

                
            }
        }
    }
}
