using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigurnosna_vrata
{
    public partial class FormOtvaranjeVrata : Form
    {
        public FormOtvaranjeVrata()
        {
            InitializeComponent();
        }

        private void Button501_Click(object sender, EventArgs e)
        {
            int brKartice = int.Parse(tbBrojKartice.Text.ToString());
            int pin = int.Parse(tbPIN.Text.ToString());
            int brVrata = 501;
            Sigurnosna_Kontrola sigurnosnaKontorla = new Sigurnosna_Kontrola();
            if (sigurnosnaKontorla.OtvoriVrata(brKartice,pin,brVrata) == true)
            {
                MessageBox.Show("Otvaranje uspjesno");
            }
            else
            {
                MessageBox.Show("Niste otvorili vrata!");
            }

        }

        private void Button502_Click(object sender, EventArgs e)
        {
            int brKartice = int.Parse(tbBrojKartice.Text.ToString());
            int pin = int.Parse(tbPIN.Text.ToString());
            int brVrata = 502;
            Sigurnosna_Kontrola sigurnosnaKontorla = new Sigurnosna_Kontrola();
            if (sigurnosnaKontorla.OtvoriVrata(brKartice, pin, brVrata) == true)
            {
                MessageBox.Show("Otvaranje uspjesno");
            }
            else
            {
                MessageBox.Show("Niste otvorili vrata!");
            }
        }

        private void Button503_Click(object sender, EventArgs e)
        {
            int brKartice = int.Parse(tbBrojKartice.Text.ToString());
            int pin = int.Parse(tbPIN.Text.ToString());
            int brVrata = 503;
            Sigurnosna_Kontrola sigurnosnaKontorla = new Sigurnosna_Kontrola();
            if (sigurnosnaKontorla.OtvoriVrata(brKartice, pin, brVrata) == true)
            {
                MessageBox.Show("Otvaranje uspješno");
            }
            else
            {
                MessageBox.Show("Niste otvorili vrata!");
            }
        }

    }
}
