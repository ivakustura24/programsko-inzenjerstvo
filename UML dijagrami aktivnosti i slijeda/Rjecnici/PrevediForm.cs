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
    public partial class PrevediForm : Form
    {
        public PrevediForm()
        {
            InitializeComponent();
        }

        private void PrevediForm_Load(object sender, EventArgs e)
        {
            foreach (Jezik j in Repozitorij.Jezici)
            {
                cmbIzvorisni.Items.Add(j.Naziv);
                cmbOdredisni.Items.Add(j.Naziv);
            }
        }

        private void buttonPrijevod_Click(object sender, EventArgs e)
        {
            string recenica = tbRecenica.Text.ToString();
            string jezik1 = cmbIzvorisni.SelectedItem.ToString();
            string jezik2 = cmbOdredisni.SelectedItem.ToString();
            string prijevod= Repozitorij.Prevedi(recenica, jezik1, jezik2);
            tbPrevedenaRecenica.Text = prijevod;
        }

        private void tbOcisti_Click(object sender, EventArgs e)
        {
            tbRecenica.Clear();
            tbPrevedenaRecenica.Clear();
            cmbIzvorisni.Items.Clear();
            cmbOdredisni.Items.Clear();
            foreach (Jezik j in Repozitorij.Jezici)
            {
                cmbIzvorisni.Items.Add(j.Naziv);
                cmbOdredisni.Items.Add(j.Naziv);
            }

        }

        private void PocetnaButton_Click(object sender, EventArgs e)
        {
            Form prevoditelj = new Prevoditelj();
            prevoditelj.Show();
            this.Close();
        }
    }
}
