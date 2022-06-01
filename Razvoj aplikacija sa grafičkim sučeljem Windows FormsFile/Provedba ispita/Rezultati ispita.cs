using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvedbaIspitaLib;

namespace Provedba_ispita
{
    public partial class RezultatiIspitaForm : Form
    {
        private List<Pitanje> rezultati;
        public RezultatiIspitaForm(List<Pitanje> DohvaceniRezultati)
        {
            InitializeComponent(); 
            rezultati = DohvaceniRezultati;
        }

        private void RezultatiIspitaForm_Load(object sender, EventArgs e)
        {
            RezultatiIspitaDGW.DataSource = rezultati;  
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
