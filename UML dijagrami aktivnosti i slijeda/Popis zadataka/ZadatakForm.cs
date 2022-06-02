using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Popis_zadataka
{
    public partial class btnDodaj : Form
    {
        
        public btnDodaj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbNaziv.Text.ToString();
            DateTime rok = dtpKrajnjiRok.Value;

            DateTime trenutni = DateTime.Now;
            Zadatak zadatak = new Zadatak(name, rok);
            if (trenutni.Month == rok.Month)
            {
                if (trenutni.Day > rok.Day)
                {
                    zadatak.Crveni = true;

                }
                else if(trenutni.Day == rok.Day+ 1)
                {
                    zadatak.Crveni = true;
                }
                else if (trenutni.Day == rok.Day)
                {
                    zadatak.Crveni = true;
                }
            }
            else if (trenutni.Month > rok.Month)
            {
                zadatak.Crveni = true;
            }
            Repozitorij.PohraniZadatak(zadatak);
            Osvjezi();
        }

        private void btnDodaj_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            List <Zadatak> zadatci = new List<Zadatak>();
            zadatci = Repozitorij.DohvatiZadatke();
            dgwZadatci.DataSource = null;
            dgwZadatci.DataSource = zadatci; 
            foreach (DataGridViewRow row in dgwZadatci.Rows)
            {
                Zadatak z = row.DataBoundItem as Zadatak;
                if (z.Crveni == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                

            }
            dgwZadatci.Columns["Crveni"].Visible = false;
        }
    }
}
