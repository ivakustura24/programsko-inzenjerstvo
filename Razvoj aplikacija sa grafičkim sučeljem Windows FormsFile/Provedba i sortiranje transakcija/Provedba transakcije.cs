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

namespace Provedba_i_sortiranje_transakcija
{
    public partial class ProvedbaTransakcije : Form
    {
        public ProvedbaTransakcije()
        {
            InitializeComponent();

        }

        private void ProvedbaTransakcije_Load(object sender, EventArgs e)
        {
            List<Racun> racuni = Banka.DohvatiPopisRacuna().ToList();
            PlatiteljCombo.DataSource = racuni;
            List<Racun> racuni1=Banka.DohvatiPopisRacuna();
            PrimateljCombo.DataSource = racuni1;

        }

        private void ProvediiButton_Click(object sender, EventArgs e)
        {
            Racun platitelj = PlatiteljCombo.SelectedItem as Racun;
            Racun primatelj = PrimateljCombo.SelectedItem as Racun;

            double iznos = double.Parse(IznosTextBox.Text);
            Banka.ProvediTransakciju(platitelj, primatelj, iznos);
            Close();
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
