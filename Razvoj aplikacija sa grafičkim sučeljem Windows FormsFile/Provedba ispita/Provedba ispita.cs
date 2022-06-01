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
    public partial class ProvedbaIspitaForm : Form
    {
        private Pitanje pitanje;
        public ProvedbaIspitaForm()
        {
            InitializeComponent();

        }

        private void ProvedbaIspitaForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
           
        }
        public void Osvjezi()
        {
            pitanje = null;
            pitanje = IspitManager.SljedecePitanje();
            PitanjeTB.Text = pitanje.Tekst;
            List<Odgovor> odgovori = new List<Odgovor>();
            odgovori = pitanje.DohvatiOdgovore();
            OdgovorLB.DataSource = odgovori;
        }
        private void PotvrdiButton_Click(object sender, EventArgs e)
        {
           
            Odgovor odgovor = OdgovorLB.SelectedItem as Odgovor;
            PotvrdenOdgovorTextBox.Text = odgovor.Tekst;
            pitanje.PotvrdiOdgovor(odgovor);
        }

        private void SljedeceButton_Click(object sender, EventArgs e)
        {
            bool jeOdgovorio = pitanje.JeOdgovoreno();
            
            if (jeOdgovorio==false)
            {
                MessageBox.Show("Nije moguće prijeći na sljedeće pitanje jer niste potvrdili odgovor");
            }
            else
            {
                if (IspitManager.ImaJosPitanja() == true)
                {
                    Osvjezi();
                }
                else
                {
                    List <Pitanje> rezultati = new List <Pitanje>();
                    rezultati = IspitManager.DohvatiRezultate();
                    RezultatiIspitaForm nova = new RezultatiIspitaForm(rezultati);
                    nova.Show();
                    this.Hide();
                }
            }
        }
    }
}
