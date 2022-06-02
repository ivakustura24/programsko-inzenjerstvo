using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    public class Vozilo
    {
        public string Registracija { get; set; }
        public string Model { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumPredavanja { get; set; }
        public string PregledNapravio { get; set; }

        public StanjeVozila StatusVozila { get; set; }    

        public Vozilo(string registracija, string model)
        {
            StatusVozila = new StanjeVozila();
            Registracija = registracija;
            Model = model;
            
        }

        public void RezervirajVozilo()
        {
            StatusVozila.IzvrsiPrijelaz(Dogadaj.KLIJENT_ZATRAZIO_VOZILO);
            DatumRezervacije = DateTime.Now;
      
        }

        public void PredajVozilo()
        {
            StatusVozila.IzvrsiPrijelaz (Dogadaj.KLIJENT_STIGAO_PO_AUTO);
            DatumPredavanja = DateTime.Now;
     
        }

        public void PregledajVozilo(string pregledNapravio)
        {
            StatusVozila.IzvrsiPrijelaz(Dogadaj.KLIJENT_VRACA_AUTO);
            PregledNapravio = pregledNapravio;

        }

        public void AktivirajVozilo()
        {
            StatusVozila.IzvrsiPrijelaz(Dogadaj.POPRAVLJEN_KVAR);
        }

        public void DeaktivirajVozilo()
        {
            StatusVozila.IzvrsiPrijelaz(Dogadaj.KVAR);
        }

        public void UciniRaspolozivim()
        {
            StatusVozila.IzvrsiPrijelaz(Dogadaj.VOZILO_SPREMNO);
        }
    }
}
