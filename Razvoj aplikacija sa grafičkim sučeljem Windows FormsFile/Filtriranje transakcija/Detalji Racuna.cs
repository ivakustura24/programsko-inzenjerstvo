using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace Filtirranje_transakcija
{
   
    public partial class DetaljiRacunaForm : Form
    { 
        static PopisTransakcijaForm popisTransakcija = new PopisTransakcijaForm();
        public Racun racun = new Racun();
        public DetaljiRacunaForm()
        {
            InitializeComponent();
        }

        private void DetaljiRacunaForm_Load(object sender, EventArgs e)
        {
            IBANTextBox.Text = popisTransakcija.racun1.IBAN;
            VlasnikTextBox.Text = popisTransakcija.racun1.Vlasnik;
            StanjeTextBox.Text = popisTransakcija.racun1.Stanje.ToString();
            double ukupno = popisTransakcija.racun1.IzracunajUkupanPromet();
            string ukupno1 = ukupno.ToString();
            UkupniPrometTextBox.Text = ukupno1;
        }
        public void DohvatiRacun (Racun racun)
        {
            popisTransakcija.racun1 = racun;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
