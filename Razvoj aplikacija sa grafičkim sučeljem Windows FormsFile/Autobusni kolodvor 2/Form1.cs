using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace Autobusni_kolodvor_2
{
    public partial class AutobusneLinijeForm : Form
    {
        static AutobusniKolodvor Autobusni= new AutobusniKolodvor();
        public Linija linija1 = new Linija();
        public AutobusneLinijeForm()
        {
            InitializeComponent();
            PopisLinijaDataGridView.DataSource = Autobusni.DohvatiLinije();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List <Linija> lista = new List <Linija>();  
            lista= Autobusni.DohvatiLinije();
            PopisLinijaDataGridView.DataSource = null;
            PopisLinijaDataGridView.DataSource=lista;
        }

        private void PronadiButton_Click(object sender, EventArgs e)
        {
            string odrediste  = PronadiTextBox.Text.ToString();
            List<Linija> pretrazi = Autobusni.DohvatiLinije(odrediste);
          
            PopisLinijaDataGridView.DataSource = pretrazi;
            
        }

        private void KupiKartuButton_Click(object sender, EventArgs e)
        {
            
            linija1 = PopisLinijaDataGridView.CurrentRow.DataBoundItem as Linija;
            KupiKartu kupiKartu = new KupiKartu();
            kupiKartu.VratiLiniju(linija1);
            kupiKartu.ShowDialog();
            
            
        }
        

    }
}
