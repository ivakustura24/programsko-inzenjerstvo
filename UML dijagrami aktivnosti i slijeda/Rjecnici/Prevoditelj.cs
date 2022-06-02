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
    public partial class Prevoditelj : Form
    {
        public Prevoditelj()
        {
            InitializeComponent();
        }

        private void Prevoditelj_Load(object sender, EventArgs e)
        {
            
            Repozitorij.DodajJezik("Hrvatski");
            Repozitorij.DodajJezik("Engleski");
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Form DodajRijec = new DodajRijecForm();
            DodajRijec.ShowDialog();
           
        }

        private void buttonRecenica_Click(object sender, EventArgs e)
        {
            Form PrijevodForm = new PrevediForm();
            PrijevodForm.ShowDialog();
            this.Close();
        }
    }
}
