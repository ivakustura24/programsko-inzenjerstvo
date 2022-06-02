using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Glasanje
{
    public partial class GlasanjeForm : Form
    {
        Glasanje glasanje = new Glasanje();
        List<string> opcija = new List<string>()
        {
            "ZA", "PROTIV", "SUZDRŽAN"
        };
        public GlasanjeForm()
        {
            InitializeComponent();
        }

        private void btnGlasaj_Click(object sender, EventArgs e)
        {
            string oib = tBOib.Text.ToString();
            if(glasanje.MozeGlasati(oib) == false)
            {
                MessageBox.Show("Nemate pravo glasati. Ili niste na biračkom popisu ili ste već glasali!");
            }
            else
            {
                string opcija = cmbOpcija.Text.ToString();
                glasanje.Glasaj(oib, opcija);
                OsvjeziRezultate();
            }
        }

        private void OsvjeziRezultate()
        {
            lbZa.Text = glasanje.Za.ToString();
            lbProtiv.Text= glasanje.Protiv.ToString();
            lbSuzdrzan.Text = glasanje.Suzdrzan.ToString();

        }

        private void GlasanjeForm_Load(object sender, EventArgs e)
        {
            cmbOpcija.DataSource = opcija;
        }
    }
}
