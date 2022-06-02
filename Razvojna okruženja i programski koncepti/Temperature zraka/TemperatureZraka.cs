using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_zraka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string glavni = "13,2|13,6|-|14,8|15,1|-|14,2|13,7";
            string rezervni = "286,45|286,85|287,25|288,05|288,35|287,95|287,45|286,95";
            string[] poljeGlavni = glavni.Split('|');
            string[] poljeRezervni = rezervni.Split('|');
            decimal temperatura = 0;
            decimal suma = 0;
            int i = 0;
            Console.WriteLine("U proteklih 24 sata su izmjerene sljedeće temperature:");
            foreach (string s in poljeGlavni)
            {
          
                if (s != "-")
                {
                    Console.WriteLine($"{s} °C");
                    temperatura = decimal.Parse(s);
                    suma += temperatura;
                   
                }
                else
                {
                    
                    decimal kelvin = decimal.Parse(poljeRezervni[i]);
                    temperatura = kelvin - (decimal)(273.15);
                    Console.WriteLine($"{temperatura} °C");
                    suma += temperatura;
                }
                i++;
            }
            decimal prosjek = Math.Round((suma/i),1);
            Console.WriteLine($"Prosječna izmjerena temperatura je {prosjek}!");
            Console.ReadLine();
        }
    }
}


