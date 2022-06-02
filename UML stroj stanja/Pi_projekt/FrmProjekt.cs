using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_PI_Projekt
{
    public partial class FrmProjekt : Form
    {
        private Projekt _projekt;
        public FrmProjekt()
        {
            InitializeComponent();
        }

        private void FrmProjekt_Load(object sender, EventArgs e)
        {
            _projekt = new Projekt();
            OsvjeziGumbe();
        }

        private void btnZabiljeziTemu_Click(object sender, EventArgs e)
        {
            _projekt.ZabiljeziTemu(txtOpisProjekta.Text, txtOznakaTima.Text);
            OsvjeziGumbe();
        }

        private void btnPredajProjekt_Click(object sender, EventArgs e)
        {
            _projekt.PredajProjekt(dtpDatumPredaje.Value);
            OsvjeziGumbe();
        }

        private void btnOdbijProjekt_Click(object sender, EventArgs e)
        {
            _projekt.OdbijProjekt();
            OsvjeziGumbe();
        }

        private void btnPrihvatiProjekt_Click(object sender, EventArgs e)
        {
            _projekt.PrihvatiProjekt();
            OsvjeziGumbe();
        }

        private void btnZakaziObranu_Click(object sender, EventArgs e)
        {
            _projekt.ZakažiObranu(dtpDatumObrane.Value);
            OsvjeziGumbe();
        }

        private void btnOznaciKaoObranjen_Click(object sender, EventArgs e)
        {
            _projekt.OznačiKaoObranjen();
            OsvjeziGumbe();
        }

        private void OsvjeziGumbe()
        {
            txtStatus.Text = _projekt.Stanje.TrenutniStatus.ToString();
      

            btnZabiljeziTemu.Enabled = _projekt.Stanje.TrenutniStatus == Stanje.NijePrijavljenaTema;
            btnPredajProjekt.Enabled = _projekt.Stanje.TrenutniStatus == Stanje.TemaPrijavljena;
            btnPrihvatiProjekt.Enabled = _projekt.Stanje.TrenutniStatus == Stanje.ProvjerenProjekt;
            btnZakaziObranu.Enabled = _projekt.Stanje.TrenutniStatus == Stanje.PrihvaćenProjekt;
            btnOznaciKaoObranjen.Enabled = _projekt.Stanje.TrenutniStatus == Stanje.ZakazanaObrana;
            btnOdbijProjekt.Enabled = _projekt.Stanje.TrenutniStatus == Stanje.ProvjerenProjekt;

        }
    }
}
