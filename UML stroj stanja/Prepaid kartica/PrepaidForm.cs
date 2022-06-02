using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_PrepaidKartica
{
    public partial class PrepaidForm : Form
    {
        private PrepaidKartica _kartica;
        public PrepaidForm()
        {
            InitializeComponent();
        }

        private void PrepaidForm_Load(object sender, EventArgs e)
        {
            _kartica = new PrepaidKartica("HR12312414213");
            txtSerijskiBroj.Text = _kartica.SerijskiBroj;
            OsvjeziGumbe();
        }

        private void btnAktiviraj_Click(object sender, EventArgs e)
        {
            _kartica.Aktiviraj();
            OsvjeziGumbe();
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            double iznosUplate = double.Parse(txtIznosUplate.Text);
            _kartica.Uplati(iznosUplate);
            txtIznosUplate.Clear();
            OsvjeziGumbe();

        }

        private void btnIsplati_Click(object sender, EventArgs e)
        {
            try
            {
                double iznosIsplate = double.Parse(txtIznosIsplate.Text);
                _kartica.Isplati(iznosIsplate);
                txtIznosIsplate.Clear();
                OsvjeziGumbe();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            OsvjeziGumbe();

            
        }

        private void OsvjeziGumbe()
        {
            txtIznos.Text = _kartica.Iznos.ToString();
            txtStatus.Text = _kartica.TrenutniStatus.ToString();

            btnAktiviraj.Enabled = _kartica.TrenutniStatus == Status.NijeAktivna;
            btnIsplati.Enabled = _kartica.TrenutniStatus == Status.Aktivna;
            btnUplati.Enabled = _kartica.TrenutniStatus == Status.Aktivna || _kartica.TrenutniStatus==Status.NemaSredstava;
    
        }

        private void txtIznos_TextChanged(object sender, EventArgs e)
        {
            int iznos;
            int.TryParse(txtIznos.Text, out iznos);
            _kartica.Iznos = iznos;

        }

    }
}
