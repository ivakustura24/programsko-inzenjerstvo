using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class TecajnaLista
    {
        public List<Tecaj> tecajnaLista;
         
        public TecajnaLista()
        {
            tecajnaLista = new List<Tecaj>();
            tecajnaLista.Add(new Tecaj("EUR", 7.5));
            tecajnaLista.Add(new Tecaj("JAP YEN", 17.22));
            tecajnaLista.Add(new Tecaj("BHCM", 0.26));
            tecajnaLista.Add(new Tecaj("DOLLAR", 0.20));

        }
        public void dodajTecaj ( string valuta, double tecaj)
        {
            tecajnaLista.Add(new Tecaj(valuta, tecaj));

        }
        public void ukloniTecaj (string valuta, double tecaj)
        {
            Tecaj trazeni=null;
            foreach (Tecaj t in tecajnaLista)
            {
                if (valuta == t._valuta)
                {
                    trazeni = t;
                    break;
                }
                
            }
            tecajnaLista.Remove(trazeni);
        }
    }
}
