using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_zraka_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U proteklih 24 sata izmjerene su sljedeće temperature: ");
            string meteoStanica = "13,2;C|286,85;K|-|14,8;C|15,1;C|287,95;K|14,2;C|13,7;C";
            string[] temperature = meteoStanica.Split('|');
            int i=1;
            foreach (string s in temperature)
            {
                if (s != "-")
                {
                    string[] temperatura = s.Split(';');
                    if (temperatura[1] == "C")
                        Console.WriteLine($"{i}. ocitanje = {temperatura[0]} °C");
                    else
                    {
                        decimal kelvin = decimal.Parse(temperatura[0]);
                        decimal celzijus = kelvin - (decimal)273.15;
                        Console.WriteLine($"{i}. ocitanje = {celzijus} °C");
                    }
                }
                else                                                
                    Console.WriteLine($"{i}. ocitanje = Nije uspjelo!");
                i++;
            }
            Console.ReadLine();
        }
    }
}
