using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Prijva
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            string korIme = tbKorisnickoIme.Text.ToString();
            string lozinka = tBLozinka.Text.ToString();

            RepozitorijKorisnika repozitorijKorisnika = new RepozitorijKorisnika();
            Autentifikator autentifikator = new Autentifikator();
            Korisnik trazenikorisnik = repozitorijKorisnika.DohvatiKorisnika(korIme);
            string idKor = trazenikorisnik.Id.ToString();
            bool prijava = autentifikator.PrijaviKorisnika(idKor, lozinka);

            if (prijava == true)
            {
                MessageBox.Show("Prijava uspješna!");
            }
            else
            {
                MessageBox.Show("Prijava neuspješna!");
            }
        }
    }
}
