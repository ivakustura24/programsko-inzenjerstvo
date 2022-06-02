using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Nogometne_reprezentacije
{
    internal class KontrolaSusreta
    {
        public Susret EvidentirajSusret (string oznakaDomacin, string oznakaGost, string rezultat)
        {
            Repozitorij repozitorij = new Repozitorij ();
            Reprezentacija reprezentacijaDomacin = repozitorij.DohvatiReprezentaciju(oznakaDomacin);
            Reprezentacija reprezentacijaGost = repozitorij.DohvatiReprezentaciju(oznakaGost);
            string[] polje = rezultat.Split(':');
            int brojGolovaDomacin = int.Parse(polje[0]);
            int brojGolovaGost = int.Parse(polje[1]);
            Susret susret = new Susret(reprezentacijaDomacin, brojGolovaDomacin, reprezentacijaGost, brojGolovaGost);
            return susret;
        }
    }
}
