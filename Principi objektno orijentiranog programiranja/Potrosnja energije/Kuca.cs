using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrošnja_energije
{
    internal class Kuca
    {
        static Brojilo broj = new Brojilo();
        public List<Brojilo> Brojila;

        public Kuca()
        {

            Brojila = new List<Brojilo>();
            Brojila.Add(new Brojilo("HEP_101", TipBrojila.Struja, 34235, 32150));
            Brojila.Add(new Brojilo("TP_222", TipBrojila.Plin, 11500, 10400));
            Brojila.Add(new Brojilo("VAR_123", TipBrojila.Voda, 16225, 16100));

        }
        private double DohvatiCijenuEnergenta (TipBrojila tip)
        {
            double cijena = 0;
            if (tip == TipBrojila.Voda)
                cijena = 3.5;

            else if (tip == TipBrojila.Plin)
                cijena = 0.20;
            else
                cijena = 0.10;
            return cijena;
            }
        public double IzracunajIznosZaBrojilo (Brojilo brojilo)
        {
            double iznos =0;
            foreach (Brojilo b in Brojila)
            {
                
                if (b == brojilo)
                {
                    iznos = broj.OcitajPotrosnju(b) * DohvatiCijenuEnergenta(b.Tip);
                }
            }
            return iznos;
        }
        public double IzracunajIznosUkupno()
        {
            double ukupno=0;
            foreach (Brojilo b in Brojila)
            {
                ukupno = ukupno+ IzracunajIznosZaBrojilo(b);
            }
            return ukupno;
        }
    }

 }

