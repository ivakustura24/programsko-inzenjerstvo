using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite godinu rođenja ");
            string godina = Console.ReadLine();
            int god = int.Parse(godina);
            int starost = DateTime.Now.Year - god;
            int prijestupna = 0;
            for ( int i=god; i<DateTime.Now.Year; i++)
            {
                if( (i%4 == 0))
                {
                    if ((i % 100 != 0)) prijestupna++;
                    else if( (i % 100 ==0) && (i % 400 == 0))
                    
                        prijestupna++;
                }
            }
            Console.WriteLine($"Starost korisnika {starost}, a broj preživljenih prijestupnih godina iznosi {prijestupna}");
            Console.Read();
        }
    }
}
