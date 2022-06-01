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

namespace Registracija_i_prijava
{
    public partial class LogInForm : Form
    {
        User user;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username  = UsernameTB.Text;
            string password = PasswordTB.Text;
            Autentificator.LogIn(username,password);
            user = Autentificator.LoggedUser;
            if (user == null)
            {
                MessageBox.Show("Entered credentials are not valid!");
            } 
            else
            {

                MessageBox.Show($"User {user.FirstName} {user.LastName} succesfuly logged in!");
            }
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm nova = new RegisterForm();
            nova.Show();
            this.Hide();
        }
    }
}
