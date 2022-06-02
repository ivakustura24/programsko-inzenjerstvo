using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjecnici
{
    internal static class Repozitorij
    {
        public static List <Jezik> Jezici { get; set; } = new List<Jezik> ();
        public static List <string> Hrvatski { get; set; } = new List<string> ();   
        public static List <string> Engleski { get; set; } = new List<string> ();
        public static void DodajJezik(string oznakaJezika)
        {
            Jezik jezik = new Jezik();
            jezik.Naziv = oznakaJezika;
            Jezici.Add(jezik);
            
        }

        public static void PohraniRijec ( string rijec, string prijevod, string jezik1, string jezik2)
        {
            if (jezik1 == "Hrvatski")
            {
                Hrvatski.Add(rijec);
                Engleski.Add(prijevod);
            }
            else
            {
                Hrvatski.Add(prijevod);
                Engleski.Add(rijec);
            }
        }

        public static string Prevedi (string recenica, string jezik1, string jezik2)
        {
            string[] polje = recenica.Split(' ');
            string prijevod = "";

            for (int i = 0; i<polje.Length; i++)
            {
                bool postoji = false;
                if (jezik1 == "Hrvatski" && jezik2== "Engleski")
                {
                    for (int j= 0; j<Hrvatski.Count; j++)
                    {
                        if (polje[i] == Hrvatski[j])
                        {
                            prijevod += $"{Engleski[j]} ";
                            postoji = true;
                        }
                    }
                    if (postoji == true)
                        prijevod += " X ";
                }
               
            }
            for (int i = 0; i < polje.Length; i++)
            {
                bool postoji = false;
                if (jezik1 == "Engleski" && jezik2 == "Hrvatski")
                {
                    for (int j = 0; j < Engleski.Count; j++)
                    {
                        if (polje[i] == Engleski[j])
                        {
                            prijevod += $"{Hrvatski[j]} ";
                            postoji = true;
                        }
                    }
                    if (postoji == false)
                        prijevod += " X ";
                }

            }

            return prijevod;
        }
    }
}
