using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonetska_abeceda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word (velikim slovima): ");
            string unos= Console.ReadLine();
            string[] fonetska_abeceda = new string[]
            {
                "Alfa", "Bravo", "Charlie",
                "Delta", "Echo", "Foxtrot",
                "Golf", "Hotel", "India",
                "Juliett", "Kilo", "Lima",
                "Mike", "November", "Oscar",
                "Papa", "Quebec", "Romeo",
                "Sierra", "Tango", "Uniform",
                "Victor", "Whiskey", "Xray",
                "Yankee", "Zulu"
            };
            unos.ToArray();
            Console.Write("Your word in phonetic alphabet looks like this: ");
            for (int i=0; i<unos.Length; i++)
            {
                string rijec= unos[i].ToString();
                for (int j=0; j<fonetska_abeceda.Length; j++)
                {
                    if (fonetska_abeceda[j].StartsWith(rijec))
                    {
                        Console.Write($"{fonetska_abeceda[j]} ");
                    }
                }
            }
            Console.Read();
        }
    }
}
