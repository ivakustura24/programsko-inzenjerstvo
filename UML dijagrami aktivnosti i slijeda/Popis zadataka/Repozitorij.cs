using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Popis_zadataka
{
    internal static class Repozitorij
    {
        public static List <Zadatak> Zadatci = new List <Zadatak>();
        public static void PohraniZadatak(Zadatak zadatak)
        {
            Zadatci.Add(zadatak);
            Zadatci.Sort((x, y) => string.Compare(x.Name, y.Name));
           
           
        }
        public static List <Zadatak> DohvatiZadatke()
        {
            
            return Zadatci;
        }
    }
}
