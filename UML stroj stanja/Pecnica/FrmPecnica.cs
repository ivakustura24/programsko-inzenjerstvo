using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_Oven
{
    public partial class FrmPecnica : Form
    {
        Pecnica pecnica = new Pecnica();
        public FrmPecnica()
        {
            InitializeComponent();
        }

        private void FrmPerilica_Load(object sender, EventArgs e)
        {

            OsvjeziGumbe();
        }



        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if(pecnica.Stanje.TrenutnoStanje == Stanje.Ugašena)
            {
                pecnica.Upali();
            }
            else if(pecnica.Stanje.TrenutnoStanje == Stanje.Upaljena)
            {
                pecnica.Ugasi();
            }
            OsvjeziGumbe();
        }

        private void btn150C_Click(object sender, EventArgs e)
        {
            pecnica.OdaberiProgram(ProgramRada.Pečenje_150C);
            OsvjeziGumbe();
        }

        private void btn180C_Click(object sender, EventArgs e)
        {
            pecnica.OdaberiProgram(ProgramRada.Pečenje_180C);
            OsvjeziGumbe();
        }

        private void btn200C_Click(object sender, EventArgs e)
        {
            pecnica.OdaberiProgram(ProgramRada.Pečenje_200C);
            OsvjeziGumbe();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pecnica.ZapocniPecenje();
            OsvjeziGumbe();
        }

        private void btnIstekloVrijeme_Click(object sender, EventArgs e)
        {
            pecnica.OznaciKaoZavrseno();
            OsvjeziGumbe();
        }

        private void btnOhladiPecnicu_Click(object sender, EventArgs e)
        {
            pecnica.OhladiPecnicu();
            OsvjeziGumbe();
        }
        private void OsvjeziGumbe()
        {
            txtStatus.Text = pecnica.Stanje.TrenutnoStanje.ToString();

            btnOnOff.Enabled = pecnica.Stanje.TrenutnoStanje == Stanje.Upaljena || pecnica.Stanje.TrenutnoStanje == Stanje.Ugašena;
            btn150C.Enabled = pecnica.Stanje.TrenutnoStanje == Stanje.Upaljena;
            btn180C.Enabled = pecnica.Stanje.TrenutnoStanje == Stanje.Upaljena;
            btn200C.Enabled = pecnica.Stanje.TrenutnoStanje == Stanje.Upaljena;

            btnStart.Enabled = pecnica.Stanje.TrenutnoStanje == Stanje.ProgramOdabran;
            btnIstekloVrijeme.Enabled = pecnica.Stanje.TrenutnoStanje == Stanje.PečenjeZapočeto;
            btnOhladiPecnicu.Enabled = pecnica.Stanje.TrenutnoStanje == Stanje.PečenjeZavršilo;
        }
    }
}
