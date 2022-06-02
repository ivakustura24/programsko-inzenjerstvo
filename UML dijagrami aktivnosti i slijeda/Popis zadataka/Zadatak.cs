using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Popis_zadataka
{
    internal class Zadatak
    {
        public string Name { get; set; }
        public DateTime KrajnjiRok { get; set; }

        public bool Crveni { get; set; }
        public Zadatak (string name, DateTime krajnjiRok)
        {
            Name = name;
            KrajnjiRok = krajnjiRok;
            Crveni = false;
        }

        
    }
}
