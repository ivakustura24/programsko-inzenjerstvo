using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Godina: ");
            int godina = int.Parse(Console.ReadLine());
            Console.Write("Mjesec: ");
            int mjesec = int.Parse(Console.ReadLine());
            int tekucaGodina = DateTime.Now.Year;
            int tekuciMjesec = DateTime.Now.Month;
            int tekuciDan = DateTime.Now.Day;
            int sumaGodina = tekucaGodina - godina - 2;
            int sumaMjesec ;
            int sumaDani ;
            if (sumaGodina > 0)
            {
                sumaMjesec = (12- mjesec)+ tekuciMjesec + (sumaGodina*12);
                sumaDani = (sumaMjesec-1) * 30 + tekuciDan;
            }
            else
            {
                sumaMjesec =  (12- mjesec) + tekuciMjesec;
                sumaDani = (sumaMjesec-1) * 30 + tekuciDan;
            }
            Console.WriteLine($"{sumaMjesec} mjeseci");
            Console.WriteLine($"{sumaDani} dana");

            Console.ReadLine();

        }
    }
}
