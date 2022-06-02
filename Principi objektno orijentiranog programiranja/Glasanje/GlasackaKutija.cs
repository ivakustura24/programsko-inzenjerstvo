using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class GlasackaKutija
    {
        private List<Glas> Glasovi=new List<Glas>();
    
        private bool VecGlasao (string oib)
        {
            foreach(Glas g in Glasovi)
            {
                if (g.OIB == oib)
                { 
                    return true;
                  
                }
                
            }
            return false;
        }
        public void Glasaj (string oib, string odabir)
        {
            
            if (VecGlasao(oib) == false)
            {
                Glasovi.Add(new Glas(oib, odabir));
                Console.WriteLine("Uspješno ste glasali!");
            }
            else
                Console.WriteLine("Glasač je već glasao!");
        }
        public void DohvatiRezultateGlasovanja()
        {
            int Za=0, Protiv=0, Suzdrzan = 0;
            foreach (Glas g in Glasovi)
            {
                if (g.Odabir=="Z")
                    Za ++;
                else if (g.Odabir =="P")
                    Protiv ++;
                else
                    Suzdrzan ++;
            }
            
            Console.WriteLine($"Rezultati glasanja: ZA = {Za}, PROTIV = {Protiv}, SUZDRŽAN = {Suzdrzan}. ");
        }
        
    }
}
