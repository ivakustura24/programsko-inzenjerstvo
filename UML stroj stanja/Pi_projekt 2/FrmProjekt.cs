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
            _projekt.ZabiljeziTemu(txtOpisTeme.Text, txtOznakaTima.Text);
            OsvjeziGumbe();
        }

        private void btnPredajPrvuFazu_Click(object sender, EventArgs e)
        {
            _projekt.PredajPrvuFazu(dtpDatumPrveFaze.Value);
            OsvjeziGumbe();
        }

        private void btnOdbijTemu_Click(object sender, EventArgs e)
        {
            _projekt.OdbijTemu();
            OsvjeziGumbe();
        }

        private void btnPrihvatiTemu_Click(object sender, EventArgs e)
        {
            _projekt.PrihvatiTemu();
            OsvjeziGumbe();
        }

        private void btnPredajCijeliProjekt_Click(object sender, EventArgs e)
        {
            _projekt.PredajCijeliProjekt(dtpDatumPredajeCijelogProjekta.Value);
            OsvjeziGumbe();
        }

        private void btnOcijeni_Click(object sender, EventArgs e)
        {
            _projekt.OcijeniProjekt(int.Parse(txtBrojBodova.Text));
            OsvjeziGumbe();
        }

        private void OsvjeziGumbe()
        {
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();

            txtBrojBodova.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.ProjektPredan;
            txtOznakaTima.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.TemaNijePrijavljena;
            txtOpisTeme.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.TemaNijePrijavljena;

            dtpDatumPrveFaze.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.TemaPrihvaćena;
            dtpDatumPredajeCijelogProjekta.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.PredanaPrvaFaza;

            btnZabiljeziTemu.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.TemaNijePrijavljena;
            btnOdbijTemu.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.ProvjeriTemu || _projekt.Stanje.TrenutnoStanje ==Stanje.TemaPrijavljena;
            btnPrihvatiTemu.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.ProvjeriTemu || _projekt.Stanje.TrenutnoStanje == Stanje.TemaPrijavljena; ;
            btnPredajPrvuFazu.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.TemaPrihvaćena;
            btnPredajCijeliProjekt.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.PredanaPrvaFaza;
            btnOcijeniProjekt.Enabled = _projekt.Stanje.TrenutnoStanje == Stanje.ProjektPredan;
        }
    }
}
