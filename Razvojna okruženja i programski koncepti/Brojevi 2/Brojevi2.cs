using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brojevi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A= ");
            int a =int.Parse (Console.ReadLine());
            Console.Write("B= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C= ");
            int c = int.Parse(Console.ReadLine());
            int suma = 0;
            int[] polje=new int[b-a];
            int index = 0;
            for (int i=a; i<=b; i++)
            {
                if (i % c == 0)
                {
                    polje[index]=i;
                    suma+=i;
                    index++;
                }
            }
            Console.Write("Rezultat je ");

            for (int i=0; i<index;i++) 
            {
                if (i == (index - 1))
                    Console.Write(polje[i]);
                else
                    Console.Write($"{polje[i]},");
            }
            Console.WriteLine();
            Console.WriteLine($"Suma je {suma}.");

            Console.Read();
        }
        
    }
}
