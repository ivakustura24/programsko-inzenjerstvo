using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    
    internal class Program
    {
        static Mjenjacnica mjenjacnica = new Mjenjacnica();
        static void Main(string[] args)
        {
            Console.WriteLine("MJENJAČNICA");
            Console.WriteLine("---------------------");
            Console.WriteLine("Unesite iznos za promjenu ");
            int iznos = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite odredišnu valutu");
            string valuta = Console.ReadLine();
            Potvrda nova =mjenjacnica.PromijeniNovac(iznos, valuta);
            mjenjacnica.IspisPotvrde(nova, valuta);

            Console.ReadLine();

        }
    }
}
