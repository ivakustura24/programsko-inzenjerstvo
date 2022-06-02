using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Banka
    {
        private List<Racun> Racuni;
        
        public Banka()
        {
            Racuni = new List<Racun>();
            Racuni.Add(new Racun("HR11", 100000));
            Racuni.Add(new Racun("HR22", 50000));
            Racuni.Add(new Racun("HR33", 12000));
            Racuni.Add(new Racun("HR44", 36000));
        }
        private Racun DohvatiRacun (string iban)
        {
            Racun trazeniRacun = new Racun();
            foreach (Racun r in Racuni)
            {
                if (iban==r.IBAN)
                {
                    trazeniRacun = r;
                    break;
                }
            }
            return trazeniRacun;
        }
        public Transakcija IzvrsiPlacanje (string ibanPlatitelja, string ibanPrimatelja, int iznos)
        {
            Transakcija novaTransakcija = new Transakcija();
            novaTransakcija.Platitelj = DohvatiRacun(ibanPlatitelja);
            novaTransakcija.Primatelj = DohvatiRacun(ibanPrimatelja);
            novaTransakcija.Iznos= iznos;

            novaTransakcija.Platitelj.Stanje =novaTransakcija.Platitelj.Stanje- iznos;
            novaTransakcija.Primatelj.Stanje = novaTransakcija.Primatelj.Stanje + iznos;
            return novaTransakcija;
        }
    }
}
