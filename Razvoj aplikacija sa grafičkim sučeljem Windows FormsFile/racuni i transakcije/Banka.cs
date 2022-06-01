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

namespace Računi_i_transakcije
{
    public partial class BankaForm : Form
    {
        
        public BankaForm()
        {
            InitializeComponent();
          
        }

        private void BankaForm_Load(object sender, EventArgs e)
        {
            RacunidataGridView.DataSource=Banka.DohvatiPopisRacuna().ToList<Racun>();

        }

        private void PrikaziTransakcijeButton_Click(object sender, EventArgs e)
        {
            Racun racun = RacunidataGridView.CurrentRow.DataBoundItem as Racun;
            PopisTransakcijaForm nova = new PopisTransakcijaForm(racun);
            nova.ShowDialog();
        }
    }
}
