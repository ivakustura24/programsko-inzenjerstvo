using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvedbaIspitaLib2;

namespace Provedba_ispita_2
{
    public partial class IspitForm : Form
    {
        Pitanje pitanje;
        IspitManager ispitManager = new IspitManager();
        public IspitForm()
        {
            InitializeComponent();
        }

        private void IspitForm_Load(object sender, EventArgs e)

        {
          pitanje=ispitManager.SljedecePitanje();
            PitanjeTextBox.Text = pitanje.Tekst;
            Osvjezi();
         
        }
        public void Osvjezi()
        {
            List<Odgovor> sviOdgovori = new List<Odgovor>();
            sviOdgovori = ispitManager.DohvatiOdgovore(pitanje);
            AButton.Text = sviOdgovori[0].ToString();
            BButton.Text = sviOdgovori[1].ToString();
            CButton.Text = sviOdgovori[2].ToString();
            DButton.Text = sviOdgovori[3].ToString();
            if (pitanje.Status == StatusPitanja.TocnoOdgovoreno) 
            {
                AButton.Enabled = false;
                BButton.Enabled = false;
                CButton.Enabled = false;
                DButton.Enabled = false;
                PitanjeTextBox.BackColor = Color.Green;

            }
            else if(pitanje.Status == StatusPitanja.NetocnoOdgovoreno)
            {
                AButton.Enabled = false;
                BButton.Enabled = false;
                CButton.Enabled = false;
                DButton.Enabled = false;
                PitanjeTextBox.BackColor = Color.Red;
            }
            else
            {
                AButton.Enabled = true;
                BButton.Enabled = true;
                CButton.Enabled = true;
                DButton.Enabled = true;
                PitanjeTextBox.BackColor= Color.Gray;
            }
         
         

        }
        public void Bojaj()
        {
            if(pitanje.Status == StatusPitanja.TocnoOdgovoreno)
            {
                PitanjeTextBox.BackColor = Color.Green;
            }
            else if (pitanje.Status == StatusPitanja.NetocnoOdgovoreno)
            {
                PitanjeTextBox.BackColor= Color.Red;
            }
            else
            {
                PitanjeTextBox.BackColor = Color.Gray;
            }
        }
        public Odgovor VratiOdgovor(int a)
        {
            Odgovor odgovor = new Odgovor();
            List<Odgovor> odgovorList = new List<Odgovor>();
            odgovorList = ispitManager.DohvatiOdgovore(pitanje);
            odgovor = odgovorList[a];
            return odgovor;
        }
        private void AButton_Click(object sender, EventArgs e)
        {
            
            ispitManager.PotvrdiPitanje(pitanje, VratiOdgovor(0));
            Bojaj();
        }

        private void BButton_Click(object sender, EventArgs e)
        {
            ispitManager.PotvrdiPitanje(pitanje, VratiOdgovor(1));
            Bojaj();
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            ispitManager.PotvrdiPitanje(pitanje, VratiOdgovor(2));
            Bojaj();
        }

        private void DButton_Click(object sender, EventArgs e)
        {
            ispitManager.PotvrdiPitanje(pitanje, VratiOdgovor(3));
            Bojaj();
        }

        private void PrethodnoButton_Click(object sender, EventArgs e)
        {
            
           pitanje = ispitManager.PrethodnoPitanje();
            PitanjeTextBox.Text = pitanje.Tekst;
            Osvjezi();
        
        }

        private void SljedeceButton_Click(object sender, EventArgs e)
        {
            pitanje = ispitManager.SljedecePitanje();
            PitanjeTextBox.Text = pitanje.Tekst;
            Osvjezi();
        }
    }
}
