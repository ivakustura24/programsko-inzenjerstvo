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
 
    public partial class Form1 : Form
    {
        private User user = new User();
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string Username = UsernameTextBox.Text.ToString();
            string Password = PasswordTextBox.Text.ToString();
            Autentificator.LogIn(Username, Password);
            List<User> korisnici = UsersRepository.GetUsers();
            foreach (User u in korisnici)
            {
                if (u.UserName == Username)
                {
                    if(u.UserType == UserType.Employee || u.UserType==UserType.Guest)
                    {
                        MessageBox.Show("You must be administrator to log in!");
                    }
                    else
                    {
                        if(u.Password == Password)
                        {
                            Administrator_Start_Form form = new Administrator_Start_Form();
                            form.ShowDialog();
                            

                        }
                    }
                }
              
            }

            
        }
    }
}
