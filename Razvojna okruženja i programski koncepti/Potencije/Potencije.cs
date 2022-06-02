using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());
            double umnozak = 1;
            if (y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    umnozak *= x;
                    if (i != (y - 1))
                        Console.Write($"{x}*");
                    else
                        Console.Write($"{x} = {umnozak}");
                }
            }
            else
            {
                y = -y;
                for (int i=0; i<y; i++)
                {
                    
                    umnozak *= (1/((double)(x)));
                    if (i != (y - 1))
                    {
                        Console.Write(1 / ((double)(x)));
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(1 / ((double)(x)));
                        Console.Write($" = {umnozak}");
                    }

                }
            }

            Console.ReadLine();
        }
    }
}
