using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{

    internal class Mjenjacnica
    {
        static TecajnaLista tLista = new TecajnaLista();
        static KonverterValuta kValuta = new KonverterValuta();
        public Mjenjacnica() 
        { 
        }
        public Potvrda PromijeniNovac(int iznos, string valuta)
        {
            double vrijednostTecaja = 0;
            Potvrda novaPotvrda = new Potvrda();
            foreach ( Tecaj t in tLista.tecajnaLista)
            {
                if (t._valuta == valuta)
                {
                    vrijednostTecaja = t._tecaj;
                    break;
                }
            }
            double konvertirano = kValuta.Konvertiraj(iznos, vrijednostTecaja);
            double naknada = konvertirano * 0.05;
            double konacno = konvertirano - naknada;
            novaPotvrda.Iznos = iznos;
            novaPotvrda.Tecaj = vrijednostTecaja;
            novaPotvrda.Rjesenje = konvertirano;
            novaPotvrda.Naknada = naknada;
            novaPotvrda.Isplata = konacno; 

            return novaPotvrda;
        }
        public void IspisPotvrde(Potvrda nova,string valuta)
        {

            Console.WriteLine($"Datum: {nova.Datum}");
            Console.WriteLine($"Iznos za promjenu : {nova.Iznos} HRK");
            Console.WriteLine($"Po tečaju: {nova.Tecaj}");
            Console.WriteLine($"Iznosi: {nova.Rjesenje}");
            Console.WriteLine($"Naknada: 5% ({nova.Naknada} {valuta})");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Za isplatiti: {nova.Isplata} {valuta} ");

        } 
    }
}
