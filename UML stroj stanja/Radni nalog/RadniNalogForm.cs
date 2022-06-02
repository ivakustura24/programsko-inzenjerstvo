using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_RadniNalog
{
    public partial class RadniNalogForm : Form
    {
        private RadniNalog _radniNalog;
        public RadniNalogForm()
        {
            InitializeComponent();
        }

        private void RadniNalogForm_Load(object sender, EventArgs e)
        {
            _radniNalog = new RadniNalog();
            OsvjeziGumbe();
        }

        private void btnZakljucaj_Click(object sender, EventArgs e)
        {
            _radniNalog.ZakljucajNalog(txtOpis.Text);
            txtDatumKreiranja.Text = _radniNalog.DatumKreiranja.ToString();
            OsvjeziGumbe();
        }

        private void btnPredajNalog_Click(object sender, EventArgs e)
        {
            _radniNalog.PredajUProizvodnju(dtpDatumPredaje.Value);
            OsvjeziGumbe();
        }

        private void btnZapocniProizvodnju_Click(object sender, EventArgs e)
        {
            _radniNalog.ZapocniProizvodnju(dtpDatumPocetka.Value);
            OsvjeziGumbe();
        }

        private void btnDovrsiProizvodnju_Click(object sender, EventArgs e)
        {
            _radniNalog.DovrsiProizvodnju(dtpDatumDovrsetka.Value);
            OsvjeziGumbe();
        }

        private void btnOtkaziNalog_Click(object sender, EventArgs e)
        {
            _radniNalog.OtkaziNalog();
            OsvjeziGumbe();
        }

        private void OsvjeziGumbe()
        {
            txtStatus.Text = _radniNalog.Stanje.TrenutnoStanje.ToString();
            txtDatumKreiranja.Text = _radniNalog.DatumKreiranja.ToString();
           

            btnOtkaziNalog.Enabled = _radniNalog.Stanje.TrenutnoStanje == Stanje.Kreiran;
            btnZakljucaj.Enabled = _radniNalog.Stanje.TrenutnoStanje == Stanje.Kreiran;
            btnPredajNalog.Enabled = _radniNalog.Stanje.TrenutnoStanje == Stanje.Zaključan;
           
            btnZapocniProizvodnju.Enabled = _radniNalog.Stanje.TrenutnoStanje == Stanje.PredanUProizvodnju;
            btnDovrsiProizvodnju.Enabled = _radniNalog.Stanje.TrenutnoStanje == Stanje.ZapočetaProizvodnja;
        }
    }
}
