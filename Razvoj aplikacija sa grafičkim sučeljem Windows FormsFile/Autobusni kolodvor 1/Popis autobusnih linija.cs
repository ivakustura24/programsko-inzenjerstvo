using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace Autobusni_kolodvor_1
{
    public partial class Popis_autobusnih_linija : Form
    {
        

        public Popis_autobusnih_linija()
        {
            InitializeComponent();
      
        }

        private void Popis_autobusnih_linija_Load(object sender, EventArgs e)
        {
            OsvjeziLinije();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OsvjeziLinije();
        }
        private void OsvjeziLinije()
        {
            List<Linija> Popis = AutobusniKolodvor.DohvatiLinije();
            LinijedataGridView.DataSource = null;
            LinijedataGridView.DataSource = Popis;

        }

        private void IzlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void OdaberiButton_Click(object sender, EventArgs e)
        {
            KreirajKartuForm kreiraj = new KreirajKartuForm();
            if (DohvatiSelektiranuLiniju() != null)
            {
                Linija lin = DohvatiSelektiranuLiniju();
                kreiraj.linija1 = lin;
                kreiraj.UnosLinije();
                Close();
            }
   
        }
       
        public Linija DohvatiSelektiranuLiniju ()
        {
            Linija selektirana=null;
            if (LinijedataGridView.CurrentRow != null)
            {
               selektirana = LinijedataGridView.CurrentRow.DataBoundItem as Linija;
            }
            return selektirana;
        }
    }
}
