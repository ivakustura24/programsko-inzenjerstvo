using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_ServisniZahtjev
{
    public partial class FrmServisniZahtjev : Form
    {
        private ServisniZahtjev _servisniZahtjev;
        public FrmServisniZahtjev()
        {
            InitializeComponent();
           
        }

        private void FrmServisniZahtjev_Load(object sender, EventArgs e)
        {
            _servisniZahtjev = new ServisniZahtjev();
            OsvjeziGumbe();
        }

        private void btnPodnesiZahtjev_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.PodnesiZahtjev(txtOpisKvara.Text, dtpDatumIzrade.Value);
            OsvjeziGumbe();
        }

        private void btnZaprimiZahtjev_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.ZaprimiZahtjev(dtpDatumZaprimanja.Value);
            OsvjeziGumbe();
        }

        private void btnZapocniServisiranje_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.ZapocniServisiranje(dtpDatumPocetka.Value);
            OsvjeziGumbe();
        }

        private void btnZatvoriZahtjev_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.ZatvoriZahtjev(dtpDatumZatvaranja.Value);
            OsvjeziGumbe();
        }

        private void btnOdbijZahtjev_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.OdbijZahtjev();
            OsvjeziGumbe();
        }

        private void OsvjeziGumbe()
        {
            txtStatusZahtjeva.Text = _servisniZahtjev.Stanje.TrenutnoStanje.ToString();

            txtOpisKvara.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.UIzradi;
            dtpDatumZaprimanja.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.Podnesen;
            dtpDatumPocetka.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.Zaprimljen;
            dtpDatumZatvaranja.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.UPostupku;

            btnPodnesiZahtjev.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.UIzradi;
            btnOdbijZahtjev.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.Podnesen;
            btnZaprimiZahtjev.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.Podnesen;
            btnZapocniServisiranje.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.Zaprimljen;
            btnZatvoriZahtjev.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.UPostupku;
            btnOdbijZahtjev.Enabled = _servisniZahtjev.Stanje.TrenutnoStanje == Stanje.Podnesen;
        }
    }
}
