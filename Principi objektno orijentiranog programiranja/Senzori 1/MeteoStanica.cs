using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori_1
{
    internal class MeteoStanica
    {
        private List<Senzor> senzori;
        public MeteoStanica()
        {
            senzori = new List<Senzor>();
            senzori.Add(new Senzor("Senzor 1", 8.4, JedinicaMjere.Celzijus));
            senzori.Add(new Senzor("Senzor 2", 281.5, JedinicaMjere.Kelvin));
            senzori.Add(new Senzor("Senzor 3", 8.9, JedinicaMjere.Celzijus));
            senzori.Add(new Senzor("Senzor 4", 9.1, JedinicaMjere.Celzijus));
        }
        private double Pretvori(JedinicaMjere izJedinice, JedinicaMjere uJedinicu)
        {
            double suma = 0;
            if (uJedinicu == JedinicaMjere.Celzijus)
            {
                foreach (Senzor s in senzori)
                {
                    if(s.Jedinica == JedinicaMjere.Kelvin)
                    {
                        double pretvori = s.Vrijednost - 273.15;
                        suma = suma + pretvori;
                        
                    }
                    else
                    {
                        suma = suma + s.Vrijednost;
                    }
                }
                return suma;
            }
            else
            {
                foreach (Senzor s in senzori)
                {
                    if(s.Jedinica == JedinicaMjere.Kelvin)
                    {
                        suma = suma + s.Vrijednost;
                    }
                    else
                    {
                        double pretvori = s.Vrijednost + 273.15;
                        suma = suma + pretvori;
                    }
                }
                return suma;

            }
        }

        public double DohvatiProsjecnuTemperaturu(JedinicaMjere jedinica)
        {
            double suma;
            if (jedinica == JedinicaMjere.Celzijus)
                suma = Pretvori(JedinicaMjere.Kelvin, JedinicaMjere.Celzijus);
            else
                suma = Pretvori(JedinicaMjere.Celzijus, JedinicaMjere.Kelvin);
            double prosjek = suma / (double)senzori.Count();
            return prosjek;
            
        }
    }
}

