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
    public partial class PopisTransakcijaForm : Form
    {
        public PopisTransakcijaForm()
        {
            InitializeComponent();
        }

        private void PopisTransakcijaForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void StornirajButton_Click(object sender, EventArgs e)
        {
            Transakcija strornirana = PopisTransakcijaDGW.CurrentRow.DataBoundItem as Transakcija;  
            Banka.StornirajTransakciju(strornirana);
            Osvjezi();
        }
         
        public void Osvjezi()
        {

            List<Transakcija> transakcija = new List<Transakcija>();
            transakcija = Banka.DohvatiPopisTransakcija();
            PopisTransakcijaDGW.DataSource = null;
            PopisTransakcijaDGW.DataSource = transakcija;
         
        
        }

        private void ProvediButton_Click(object sender, EventArgs e)
        {
            Osvjezi();
            ProvedbaTransakcije form = new ProvedbaTransakcije();
            form.ShowDialog();
            Osvjezi();
        }
    }
}
