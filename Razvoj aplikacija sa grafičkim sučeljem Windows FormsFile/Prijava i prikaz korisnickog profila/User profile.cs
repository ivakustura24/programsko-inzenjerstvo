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

namespace Prijava_i_prikaz_korisnickog_profila
{
    public partial class UserprofileForm : Form
    {
        User trenutni = new User();
        public UserprofileForm(User user )
        {
            InitializeComponent();
            trenutni = user;
        }

        private void UserprofileForm_Load(object sender, EventArgs e)
        {
            FirstnameTB.Text=trenutni.FirstName;
            FirstnameTB.Enabled = false;

            LastnameTB.Text=trenutni.LastName;
            LastnameTB.Enabled = false;

            UsernameTB.Text = trenutni.UserName;
            UsernameTB.Enabled = false;

            PasswordTB.Text= trenutni.Password;

            if (trenutni.UserType == UserType.Administrator)
                    AdminRadio.Checked = true;
            else if(trenutni.UserType == UserType.Guest)
                    GuestRadio.Checked = true;
            else if(trenutni.UserType == UserType.Employee)
                    EmployeeRadio.Checked = true;
            AdminRadio.Enabled = false;
            GuestRadio.Enabled = false;
            EmployeeRadio.Enabled = false;
            
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Autentificator.LogOut();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }
    }
}
