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
    
    public partial class LogInForm : Form
    {
    
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = ""; 
            string password = "";
            username = UsernameTextBox.Text;
            password = PasswordTextBox.Text; 
            if( username == "" || password=="" )
            {
                MessageBox.Show("Username and password must be entered!");
            }
            else
            {
                 
                 Autentificator.LogIn(username,password);
                 User logirani = Autentificator.LoggedUser;
                 if(logirani == null)
                {
                    MessageBox.Show("Entered credentials are not valid!");
                }
                 else
                {
                    UsernameTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    UserprofileForm profil = new UserprofileForm(logirani);
                    profil.Show();
                    this.Hide();
                    
                }

            }
          
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
