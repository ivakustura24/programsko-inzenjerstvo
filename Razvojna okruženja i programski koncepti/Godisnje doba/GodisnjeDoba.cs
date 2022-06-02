using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godišnja_doba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite proizvoljan datum u formatu 'dd mmmm' (npr. 20 siječanj) ");
            string unos = Console.ReadLine();
            string[] polje = unos.Split(' ');
            int dan = int.Parse(polje[0]);
            string mj = polje[1];
            switch (mj)
            {
                case "sijecanj":
                    Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu zima. ");
                    break;

                case "veljaca":
                    Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu zima. ");
                    break;

                case "ozujak":
                    if (dan < 21 )
                        Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu zima. ");
                    else
                        Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu proljeće. ");
                    break;

                case "travanj":
                    Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu proljeće. ");
                    break;

                case "svibanj":
                    Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu proljeće.");
                    break;

                case "lipanj":
                    if (dan < 21)
                        Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu proljeće.");
                    else
                        Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu ljeto.");
                    break;
                case "srpanj":
                    Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu ljeto.");
                    break;
                case "kolovoz":
                    Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu ljeto.");
                    break;
                case "rujan":
                    if (dan < 23)
                        Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu ljeto.");
                    else
                        Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu jesen.");

                    break;

                case "listopad":
                    Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu jesen.");
                    break;

                case "studeni":
                    Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu jesen.");
                    break;

                case "prosinac":
                    if (dan < 21)
                        Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu jesen.");
                    else
                        Console.WriteLine($"Dan {dan}. {mj} pripada godišnjem dobu zima.");
                    break;
            }

            Console.Read();










        }
    }
}
