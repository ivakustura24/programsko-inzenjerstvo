using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori_1
{
    enum JedinicaMjere {Celzijus, Kelvin}
    internal class Senzor
    {
        public string Oznaka { get; set; }
        public double Vrijednost { get; set; }
        public JedinicaMjere Jedinica { get; set; }
        public Senzor() { }
        public Senzor (string oznaka, double vrijednost, JedinicaMjere jedinica)
        {
            Oznaka = oznaka;
            Vrijednost = vrijednost;
            Jedinica = jedinica;

        }
    }
}
