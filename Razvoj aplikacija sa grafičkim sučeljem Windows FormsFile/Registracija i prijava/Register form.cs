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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            User user = new User();
            string Firstname = FirstnameTB.Text;
            string Lastname = LastnameTB.Text;
            string Username = UsernameTB.Text;
            string Password = PasswordTB.Text;
            UserType Type;
            if (EmployeeRadio.Checked)
                Type = UserType.Employee;
            else if (GuestRadio.Checked)
                Type = UserType.Guest;
            else
                Type = UserType.Administrator;
            user.FirstName = Firstname;
            user.LastName = Lastname;
            user.UserName = Username;
            user.Password = Password;
            user.UserType = Type;
            Registrator.RegisterUser(user);
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();

        }
    }
}
