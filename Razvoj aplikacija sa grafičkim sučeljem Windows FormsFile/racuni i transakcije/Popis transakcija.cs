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
    public partial class PopisTransakcijaForm : Form
    {
        private Racun selektirani;
        public PopisTransakcijaForm(Racun racun)
        {
            InitializeComponent();
            selektirani = racun;
        }

        private void PopisTransakcijaForm_Load(object sender, EventArgs e)
        {
            IBANTextBox.Text = selektirani.IBAN.ToString();
            StanjeTextBox.Text = selektirani.Stanje.ToString();
            VlasnikTextBox.Text = selektirani.Vlasnik.ToString();

            IBANTextBox.Enabled = false;
            StanjeTextBox.Enabled = false;
            VlasnikTextBox.Enabled = false;
            groupBox1.Enabled = false;
            SveRadio.Checked = true;
            TransakcijeDGW.DataSource = selektirani.DohvatiTransakcije().ToList<Transakcija>();
        }

        private void PrimjeniButton_Click(object sender, EventArgs e)
        {
            List<Transakcija> list = new List<Transakcija>();
            if (SveRadio.Checked)
            {
                list = selektirani.DohvatiTransakcije();
            }
            else if (UplateRadio.Checked)
                list = selektirani.DohvatiUplate();
            else
                list = selektirani.DohvatiIsplate();
            TransakcijeDGW.DataSource = list;
        }
    }
}
