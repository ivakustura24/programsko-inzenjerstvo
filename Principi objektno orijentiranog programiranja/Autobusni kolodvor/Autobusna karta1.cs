using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobusni_kolodvor
{
    internal class AutobusniKolodvor
    {
        List<Linija> linija;
        public AutobusniKolodvor()
        {
            linija = new List<Linija>();
            linija.Add(new Linija("Varazdin", "Zagreb", 80));
            linija.Add(new Linija("Varazdin", "Cakovec", 20));
            linija.Add(new Linija("Varazdin", "Slavonski brod", 240));
            linija.Add(new Linija("Varazdin", "Krapina", 40));
            linija.Add(new Linija("Varazdin", "Novi Marof", 22));
            linija.Add(new Linija("Varazdin", "Koprivnica", 45));
            linija.Add(new Linija("Varazdin", "Virovitica", 100));
            linija.Add(new Linija("Varazdin", "Osijek", 220));
        }

        private double IzracunajCijenu (int udaljenost, string tipKarte)
        { 
                double cijena=1;
                if(tipKarte == "Regularna")
                     cijena=udaljenost*1.5;
                else if (tipKarte == "Povratna")
                    cijena = udaljenost * 2;
                else if (tipKarte== "Studentska")
                    cijena =udaljenost * 1.2;
                return cijena;  
        }
        public double KupiKartu ( string polaziste, string odrediste, string tipKarte)
        {
            int udaljenost = 0;
            foreach (Linija l in linija )
            {
                if (polaziste == l.Polaziste && odrediste == l.Odrediste)
                    udaljenost = l.Udaljenost;
             
            }
            double rjesenje = IzracunajCijenu(udaljenost, tipKarte);
            return rjesenje;
        }
    }
}
