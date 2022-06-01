using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novčana_naknada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime zaposlenika: ");
            string zaposlenik =Console.ReadLine();
            string[] zaposlenici = new string[9]
            {
                "Ivan Ivic;8NS", "Ivan Ivic;6DS", "Ivan Ivic;4DS",
                "Ivan Ivic;4P", "Pero Peric;3NS","Pero Peric;5DS",
                "Pero Peric;7DS", "Pero Peric;4DS", "Pero Peric;3P"
            };
            double koeficijent1;
            double suma = 0;
            double zbroj = 1;
            foreach (string s in zaposlenici)
            {
                string[] polje = s.Split(';');
                if(polje[0]== zaposlenik)
                {
                    string sati = polje[1].Substring(0,1);
                    int sati1 = int.Parse(sati);
                    string koeficijent = polje[1].Substring(1);
                    if (koeficijent == "NS")
                        koeficijent1 = 1.5;
                    else if (koeficijent == "DS")
                        koeficijent1 = 1;
                    else
                        koeficijent1 = 2;
                    zbroj = sati1 * koeficijent1 * 150;
                    suma += zbroj;
                }
                
            }
            Console.WriteLine($"Zaposleniku {zaposlenik} treba isplatiti ukupno {suma} kuna!");
            Console.ReadLine();
        }
         
    }
}
