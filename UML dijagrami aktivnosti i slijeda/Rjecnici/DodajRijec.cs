using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rjecnici
{
    public partial class DodajRijecForm : Form
    {
        public DodajRijecForm()
        {
            InitializeComponent();
        }

        private void DodajRijecForm_Load(object sender, EventArgs e)
        {
            foreach (Jezik j in Repozitorij.Jezici)
            {
                cmbjezik1.Items.Add(j.Naziv);
                cmbJezik2.Items.Add(j.Naziv);
            }
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            string rijec1 = tbRijec.Text.ToString();
            string prijevod = tbPrijevod.Text.ToString();

            string jezik1 = cmbjezik1.SelectedItem.ToString();
            string jezik2 = cmbJezik2.SelectedItem.ToString();

            Repozitorij.PohraniRijec(rijec1, prijevod, jezik1, jezik2);
            MessageBox.Show("Uspješno unesena riječ u riječnik!");
            this.Close();
        }
    }
}
