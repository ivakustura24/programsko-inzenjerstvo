using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    public class StanjeVozila
    {
        public Status TrenutniStatus { get; set; }
        public Dictionary<Prijelaz, Status> dozvoljeniPrijelazi;

        public StanjeVozila()
        {

            TrenutniStatus = Status.Raspoloživ;
            DefinirajDozvoljenePrijelaze();
        }
        private void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, Status>();
            dozvoljeniPrijelazi.Add(new Prijelaz(Status.Raspoloživ, Dogadaj.KLIJENT_ZATRAZIO_VOZILO), Status.Rezerviran);
            dozvoljeniPrijelazi.Add(new Prijelaz(Status.Rezerviran, Dogadaj.KLIJENT_STIGAO_PO_AUTO), Status.UUporabi);
            dozvoljeniPrijelazi.Add(new Prijelaz(Status.UUporabi, Dogadaj.KLIJENT_VRACA_AUTO), Status.NaPregledu);
            dozvoljeniPrijelazi.Add(new Prijelaz(Status.NaPregledu, Dogadaj.VOZILO_SPREMNO), Status.Raspoloživ);
            dozvoljeniPrijelazi.Add(new Prijelaz(Status.Raspoloživ, Dogadaj.KVAR), Status.UKvaru);
            dozvoljeniPrijelazi.Add(new Prijelaz(Status.UKvaru, Dogadaj.POPRAVLJEN_KVAR), Status.Raspoloživ);
        }

        public void IzvrsiPrijelaz(Dogadaj dogadaj)
        {
            Status odredisniStatus;
            Prijelaz prijelaz = new Prijelaz(TrenutniStatus, dogadaj);
            if (dozvoljeniPrijelazi.TryGetValue(prijelaz, out odredisniStatus)== false)
            {
                throw new ApplicationException($"Prijelaz {TrenutniStatus} -> {dogadaj} nije dozvoljen!");
            }
            TrenutniStatus = odredisniStatus;
        }
    }
}
