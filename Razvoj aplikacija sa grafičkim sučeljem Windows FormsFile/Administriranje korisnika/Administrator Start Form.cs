using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutentifikacijaLib;

namespace Administriranje_korisnika
{
    public partial class Administrator_Start_Form : Form
    {
        private User user = new User();
        public Administrator_Start_Form()
        {
            InitializeComponent();
            OsvjeziPopis();

        }

        private void TablicaAdministratoraDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OsvjeziPopis();
        }
        public void OsvjeziPopis()
        {
            List<User> korisnici = UsersRepository.GetUsers();
            TablicaAdministratoraDataGridView.DataSource = korisnici;
        }

        private void AktivirajKorisnikaButton_Click(object sender, EventArgs e)
        {
            User aktivirani = DohvatiSelektiranogKorisnika();
            aktivirani.Status = UserStatus.Activated;
            OsvjeziPopis();
        
            

        }
        private User DohvatiSelektiranogKorisnika()
        {
            User trazeni = null;
            if (TablicaAdministratoraDataGridView.CurrentRow != null)
            {
                trazeni = TablicaAdministratoraDataGridView.CurrentRow.DataBoundItem as User;
            }
            return trazeni;
        }

        private void DeaktivirajKorisnikaButton_Click(object sender, EventArgs e)
        {
            User deaktivirani = DohvatiSelektiranogKorisnika();
            deaktivirani.Status = UserStatus.Deactivated;
            OsvjeziPopis();

        }

        private void TablicaAdministratoraDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            User odabrani = DohvatiSelektiranogKorisnika();
            if (odabrani.Status == UserStatus.Activated)
            {
                AktivirajKorisnikaButton.Enabled = false;
                DeaktivirajKorisnikaButton.Enabled = true;
            }
            else if (odabrani.Status ==UserStatus.Deactivated)
            {
                AktivirajKorisnikaButton.Enabled = true;
                DeaktivirajKorisnikaButton.Enabled = false;
            }

        }
    }
}
