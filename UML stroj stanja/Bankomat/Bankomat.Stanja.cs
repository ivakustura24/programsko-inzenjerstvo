using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bankomat
{
    partial class Bankomat
    {
        public enum Stanje
        {
            Mirovanje,
            ProvjeraPina,
            OdabirIznosaZaIsplatu,
            IsplataGotovine,
            BlokiranRačun
        }

        public enum Dogadjaj
        {
            KARTICA_UMETNUTA,
            PIN_UNESEN,
            IZNOS_UNESEN,
            ISPLATA_GOTOVA,
            ODUSTANI
        }

        public Stanje TrenutnoStanje { get; set; }
        private Action[,] strojStanja;

        public void ObradiDogadjaj(Dogadjaj dogadaj)
        {
            this.strojStanja[(int)this.TrenutnoStanje, (int)dogadaj].Invoke();
        }

        private void DefinirajMatricuPrijelazaStanja()
        {
            TrenutnoStanje = Stanje.Mirovanje;

            //TODO - Dopuniti konačnu matricu prijelaza stanja s pozivom odgovarajućih metoda
            //Metode su već popisane ispod, te ih treba samo pozvati, a metoda IznosUnesen je 
            //već implementirana kako bi poslužila kao primjer
            strojStanja = new Action[4, 5]
            {
                //KARTICA_UMETNUTA      //PIN UNESEN     //IZNOS UNESEN      //ISPLATA_GOTOVA            //ODUSTANI
                {this.KarticaUmetnuta,  null,               null,               null,                   this.Odustani},      //Mirovanje
                {null,                  this.PinUnesen,     null,               null,                   this.Odustani},      //ProvjeraPina
                {null,                  null,               this.IznosUnesen,   null,                   null},              //OdabirIznosaZaIsplatu
                {null,                  null,               null,               this.IsplataGotova,     null},              //IsplataGotovine
            };
        }

        private void KarticaUmetnuta()
        {
            TrenutnoStanje = Stanje.ProvjeraPina;

        }

        private void PinUnesen()
        {
            if (Pogreske < 3)
            {
                if (Pin == IspravanPin)
                {
                    TrenutnoStanje = Stanje.OdabirIznosaZaIsplatu;
                }
                else
                {
                    Pogreske++;
                    MessageBox.Show($"Unijeli ste pogrešan pin, ostalo je još {3 - Pogreske} pokušaja!");
                }
            }
            else
            {
                MessageBox.Show("Prekoračili ste mogući broj unošenja pina!");
                TrenutnoStanje = Stanje.BlokiranRačun;
            }
       
            
            
        }

        private void IznosUnesen()
        {
            if (Iznos <= MaxIznos)
            {
                TrenutnoStanje = Stanje.IsplataGotovine;
            }
            else
            {
                MessageBox.Show("Nedovoljno sredstava!");
            }
        }

        private void IsplataGotova()
        {
            MaxIznos = MaxIznos - Iznos;
            TrenutnoStanje = Stanje.Mirovanje;

        }

        private void Odustani()
        {
            TrenutnoStanje = Stanje.Mirovanje;
        }
    }
}
