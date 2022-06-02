using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{

    internal class Prvenstvo
    {
        public List<Reprezentacija> Reprezentacije = new List<Reprezentacija>();
        public List<Utakmica> Utakmice = new List<Utakmica>();
        static Utakmica utakmica = new Utakmica();
        public Prvenstvo()
        {
        }
        public void DodajReprezentaciju(string oznaka, string naziv)
        {
            Reprezentacije.Add(new Reprezentacija(oznaka, naziv));
        }
        public void DodajUtakmicu(string domacin,string gost, int bodovidomacin, int bodovigost)
        {
            Reprezentacija repDomacin = null;
            Reprezentacija repGost = null;
            foreach (Reprezentacija r in Reprezentacije)
            {
                if (r.Oznaka == domacin)
                    repDomacin = r;
                if(r.Oznaka == gost)
                    repGost = r;
            }
            Utakmice.Add(new Utakmica(repDomacin, repGost, bodovidomacin, bodovigost));
        }
        
        public void GenerirajTablicuRezultata()
        {

            foreach (Utakmica u in Utakmice)
            {
                Console.WriteLine( utakmica.GenerirajIspis(u));
            }
          
        }
        public int Odredi_OU(Reprezentacija oznaka)
        {
            int broj = 0;
            foreach (Utakmica u in Utakmice)
            {
                if (u.Domacin== oznaka || u.Gost==oznaka)
                    broj++;
            }
            return broj;
        }
        public int Odredi_POB(Reprezentacija oznaka)
        {
            int broj = 0;
            foreach (Utakmica u in Utakmice)
            {
                if (u.Domacin== oznaka)
                {
                    if (u.BodoviDomacin > u.BodoviGost)
                        broj++;
                }
                else if(u.Gost == oznaka)
                {
                    if (u.BodoviGost > u.BodoviDomacin)
                        broj++;
                }
            }
            return broj;
        }
        public int Odredi_NER (Reprezentacija oznaka)
        {
            int broj = 0;
            foreach(Utakmica u in Utakmice)
            {
                if (u.Domacin == oznaka || u.Gost == oznaka)
                {
                    if (u.BodoviDomacin == u.BodoviGost)
                        broj++;
                }
            }
            return broj;
        }

        public int Odredi_IZG (Reprezentacija oznaka)
        {
            int broj = 0;
            foreach (Utakmica u in Utakmice)
            {
                if (u.Domacin == oznaka)
                {
                    if (u.BodoviDomacin < u.BodoviGost)
                        broj++;
                }
                else if (u.Gost == oznaka)
                {
                    if (u.BodoviGost < u.BodoviDomacin)
                        broj++;
                }
            }
            return broj;
        }
        public int Odredi_POZ (Reprezentacija oznaka)
        {
            int broj = 0;
            foreach(Utakmica u in Utakmice)
            {
                if (u.Domacin == oznaka)
                    broj = broj + u.BodoviDomacin;
                else if(u.Gost == oznaka)
                {
                    broj = broj + u.BodoviGost;
                }
            }
            return broj;
        }
        public int Odredi_PRZ(Reprezentacija oznaka)
        {
            int broj = 0;
            foreach (Utakmica u in Utakmice)
            {
                if (u.Domacin == oznaka)
                    broj = broj + u.BodoviGost;
                else if (u.Gost == oznaka)
                {
                    broj = broj + u.BodoviDomacin;
                }
            }
            return broj;
        }
        public int Odredi_RUZ (Reprezentacija oznaka)
        {
            int broj = 0;
            broj = Odredi_POZ(oznaka) - Odredi_PRZ(oznaka);
            return broj;
        }
        public int Odredi_BOD (Reprezentacija oznaka)
        {
            int broj = 0;
            broj = Odredi_POB(oznaka) * 3 + Odredi_NER(oznaka) * 1;
            return broj;
        }
        public void GenerirajBodovnuLjestvicu()
        {
            Console.WriteLine("BODOVNA LJESTVICA");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("REP   OU   POB   NER   IZG   POZ   PRZ   RUZ   BOD");
            Console.WriteLine("--------------------------------------------------");

            foreach (Reprezentacija r in Reprezentacije)
            {
                Console.WriteLine($"{r.Oznaka}   {Odredi_OU(r)}     {Odredi_POB(r)}     {Odredi_NER(r)}     {Odredi_IZG(r)}     {Odredi_POZ(r)}     {Odredi_PRZ(r)}    {Odredi_RUZ(r)}     {Odredi_BOD(r)}");
            }
        }
    }
}