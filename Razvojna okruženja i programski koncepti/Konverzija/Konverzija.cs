using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Console.WriteLine("Upišite iznos KUNA (cjeli broj) koje želite promijeniti (u tekstualnom obliku):");
            string unos = Console.ReadLine();
            Console.WriteLine("Upišite tečaj EUR-a (u brojčanom decimalnom obliku):");
            double tecaj = double.Parse(Console.ReadLine());
            string[] polje = unos.Split(' ');
            foreach (string i in polje)
            {
                switch (i)
                {
                    case "jedan":
                        lista.Add(1);
                        break;
                    case "dva":
                        lista.Add(2);
                        break;
                    case "tri":
                        lista.Add(3);
                        break;
                    case "cetiri":
                        lista.Add(4);
                        break;
                    case "pet":
                        lista.Add(5);
                        break;
                    case "sest":
                        lista.Add(6);
                        break;
                    case "sedam":
                        lista.Add(7);
                        break;
                    case "osam":
                        lista.Add(8);
                        break;
                    case "devet":
                        lista.Add(9);
                        break;
                }
            }
            int duljina = lista.Count;
            int zbroj = 0;
            for (int i = 0; i < duljina; i++)
            {
                int broj = 1;
                for (int j = i; j< duljina-1; j++)
                {
                    broj = broj * 10;

                }
                broj = lista[i] * broj;
                zbroj = broj + zbroj;
            }
            double rezultat = zbroj / tecaj;
            Console.WriteLine($"{zbroj} KN po tečaju {tecaj} iznosi {rezultat} EUR");
            Console.ReadLine();
        }
    }
}
