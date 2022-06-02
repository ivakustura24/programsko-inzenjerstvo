using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_Dishwasher
{
    public partial class FrmPerilica : Form
    {
        Perilica perilica = new Perilica();
        public FrmPerilica()
        {
            InitializeComponent();
        }

        private void FrmPerilica_Load(object sender, EventArgs e)
        {
            
            OsvjeziGumbe();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if(perilica.Stanje.TrenutnoStanje == Stanje.Ugašena)
            {
                perilica.Upali();
            }
            else if(perilica.Stanje.TrenutnoStanje == Stanje.UMirovanju)
            {
                perilica.Ugasi();
            }
            OsvjeziGumbe();
        }

        private void btn60min_Click(object sender, EventArgs e)
        {
            perilica.OdaberiProgram(ProgramRada.Pranje_60min);
            OsvjeziGumbe();
        }

        private void btn90min_Click(object sender, EventArgs e)
        {
            perilica.OdaberiProgram(ProgramRada.Pranje_90min);
            OsvjeziGumbe();
        }

        private void btn120min_Click(object sender, EventArgs e)
        {
            perilica.OdaberiProgram(ProgramRada.Pranje_120min);
            OsvjeziGumbe();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            perilica.ZapocniPranje();
            OsvjeziGumbe();
        }

        private void btnPauzirajNastavi_Click(object sender, EventArgs e)
        {
            if(perilica.Stanje.TrenutnoStanje == Stanje.PranjeUToku)
            {
                perilica.PauzirajPranje();
            }
            else if(perilica.Stanje.TrenutnoStanje == Stanje.Pauzirano)
            {
                perilica.NastaviPranje();
            }
            OsvjeziGumbe();
        }

        private void btnPranjeZavrsilo_Click(object sender, EventArgs e)
        {
            perilica.OznaciPranjeZavrsilo();
            OsvjeziGumbe();
        }

        private void OsvjeziGumbe()
        {
            txtStatus.Text = perilica.Stanje.TrenutnoStanje.ToString();

            btnOnOff.Enabled = perilica.Stanje.TrenutnoStanje == Stanje.UMirovanju || perilica.Stanje.TrenutnoStanje == Stanje.Ugašena;
            btn60min.Enabled = perilica.Stanje.TrenutnoStanje == Stanje.UMirovanju;
            btn90min.Enabled = perilica.Stanje.TrenutnoStanje == Stanje.UMirovanju;
            btn120min.Enabled = perilica.Stanje.TrenutnoStanje == Stanje.UMirovanju;

            btnStart.Enabled = perilica.Stanje.TrenutnoStanje == Stanje.OdabranProgram;
            btnPauzirajNastavi.Enabled = perilica.Stanje.TrenutnoStanje == Stanje.PranjeUToku || perilica.Stanje.TrenutnoStanje == Stanje.Pauzirano;
            btnPranjeZavrsilo.Enabled = perilica.Stanje.TrenutnoStanje == Stanje.PranjeUToku;
        }
    }
}
