using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    internal class Knjiznica
    {
        private List<Knjiga> popisKnjiga;
        public Knjiznica()
        {
            popisKnjiga = new List<Knjiga>();
            popisKnjiga.Add(new Knjiga("1111", "Rat i mir", StatusKnjige.Dostupno));
            popisKnjiga.Add(new Knjiga("2222", "Ana Karenjina", StatusKnjige.NaPosudbi));
            popisKnjiga.Add(new Knjiga("3333", "Povratak kralja", StatusKnjige.Dostupno));

        }
        public Knjiga DohvatiKnjigu (string isbn)
        {
            Knjiga trazena = null ;
            foreach (Knjiga k in popisKnjiga)
            {
                if(k.ISBN == isbn)
                {
                    trazena = k;
                    break;
                }
               
            }
            return trazena;
          
        }
        public void Posudi (string isbn)
        {
            DohvatiKnjigu(isbn).Status = StatusKnjige.NaPosudbi;
            Console.WriteLine($"ISBN:{DohvatiKnjigu(isbn).ISBN}");
            Console.WriteLine($"Naslov:{DohvatiKnjigu(isbn).Naslov}");
            Console.WriteLine($"Status:{DohvatiKnjigu(isbn).Status}");
        }

    }
}
