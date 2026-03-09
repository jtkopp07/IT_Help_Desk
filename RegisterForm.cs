using System;
using System.Windows.Forms;

namespace LoginAndRegister
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text;
            string password = txtNewPassword.Text;
            string confirmPassword = txtConfirmNewPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password cannot be empty.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (DBManager.UserExists(username))
            {
                MessageBox.Show("Username already exists. Try another one.");
                return;
            }

            if (DBManager.SaveUser(username, password))
            {
                MessageBox.Show("Registration successful! You can now log in.");
                this.Close(); // Or redirect to login form
            }
            else
            {
                MessageBox.Show("An error occurred while saving user data. Please try again.");
            }
        }
    }
}
