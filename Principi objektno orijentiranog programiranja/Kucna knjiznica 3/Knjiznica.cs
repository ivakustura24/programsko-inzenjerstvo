using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Knjiznica
    {
        public List <Knjiga> Knjige;
        public List <Posudba> Posudbe;

        public Knjiznica()
        {
            Knjige = new List<Knjiga>();
            Knjige.Add(new Knjiga("1111", "Rat i mir"));
            Knjige.Add(new Knjiga("2222", "Ana Karenjina"));
            Knjige.Add(new Knjiga("3333", "Zlocin i kazna"));
        }
        public void PosudiKnjigu (string osoba, string isbn)
        {
            Posudbe = new List<Posudba>();
            Knjiga stara = new Knjiga();
            foreach (Knjiga k in Knjige)
            {
                if(k.ISBN == isbn)
                {
                    stara = k;
                    break;
                    
                }
            }
            Posudbe.Add(new Posudba(osoba, stara));
      
        }


    }
}
