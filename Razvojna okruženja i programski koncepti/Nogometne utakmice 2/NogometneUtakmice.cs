using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] polje = new string[6]
                {
                 "ARG 1:1 ISL", "HRV 2:0 NIG", "ARG 0:3 HRV",
                 "NIG 2:0 ISL", "NIG 1:2 ARG", "ISL 1:2 HRV"
                };
            
            Console.WriteLine("Upišite oznaku reprezentacije: ");
            string reprezentacija = Console.ReadLine();
            foreach (string i in polje)
            {
               string prvi = i.Substring(0,5);
               string drugi = i.Substring(6);
                if (prvi.Contains(reprezentacija))
                    Console.WriteLine($"{prvi}:{drugi}");
                else if (drugi.Contains(reprezentacija))
                {
                    string drugiRezultat = drugi.Substring(0,1);
                    string drugaReprezentacija = drugi.Substring(2);
                    string prvaReprezentacija = prvi.Substring(0,3);
                    string prviRezultat = prvi.Substring(4);
                    Console.WriteLine($"{drugaReprezentacija} {drugiRezultat}:{prviRezultat} {prvaReprezentacija}");
                }
            }



            Console.ReadLine();

            

        }
    }
}
