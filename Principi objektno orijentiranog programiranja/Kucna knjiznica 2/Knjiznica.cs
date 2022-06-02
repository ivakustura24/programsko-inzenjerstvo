using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kućna_knjižnica_2
{
    
    internal class Knjiznica
    {
        public List<Knjiga> PopisKnjiga;
        public Knjiznica()
        {
            PopisKnjiga = new List<Knjiga>();
            PopisKnjiga.Add(new Knjiga("Prstenova druzina"));
            PopisKnjiga.Add(new Knjiga("Dvije kule"));
            PopisKnjiga.Add(new Knjiga("Povratak knjiga"));
            PopisKnjiga.Add(new Knjiga("Ana Karenjina"));
            PopisKnjiga.Add(new Knjiga("Zlocin i kazna"));
            PopisKnjiga.Add(new Knjiga("Rat i mir"));
            PopisKnjiga.Add(new Knjiga("Jadnici"));

        }
        public void Posudi (string naslov, string osoba)
        {
            foreach (Knjiga k in PopisKnjiga)
            {
                if(k.Naslov== naslov)
                {
                    if (k.Dostupno == true)
                    {
                        k.Dostupno = false;
                        k.Osoba = osoba;

                    }
                   
                }
            }
            
        }
        
    }
}
