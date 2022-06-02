using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi_na_vjezbama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Vjezbe vjezbe = new Vjezbe();
            string unos;
            do
            {
                Console.WriteLine("1.Dodavanje studenta ");
                Console.WriteLine("2.Dodavanje vježbe i ocjenjivanje studenata");
                Console.WriteLine("3.Ispis bodova");
                Console.WriteLine("4.Izlaz");
                unos = Console.ReadLine();
                switch (unos)
                {
                    case "1":
                        Console.WriteLine("Unesite id studenta");
                        int id=int.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite ime studenta");
                        string ime = Console.ReadLine();
                        Console.WriteLine("Unesite prezime studenta");
                        string prezime = Console.ReadLine();
                        vjezbe.DodajStudenta(id, ime, prezime);
                        break;


                    case "2":
                        Console.WriteLine("Unesite broj vježbe");
                        int broj = int.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite id studenta");
                        Student novi =vjezbe.DohvatiStudenta(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Unesite broj bodova studenta ");
                        int bod = int.Parse(Console.ReadLine());
                        vjezbe.DodajVjezbuOcijeni(broj, novi, bod);
                        break;


                    case "3":
                        vjezbe.IspisBodova();
                        break;

                }
            } while (unos != "4");
        }
    }
}
