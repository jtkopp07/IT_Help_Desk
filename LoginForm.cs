using System;
using System.Windows.Forms;
using LoginForm;

namespace LoginAndRegister
{
    public partial class LoginForm : Form
    {
        private string loggedInUsername;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            try
            {
                string correctPassword = DBManager.GetUserPassword(enteredUsername);

                if (enteredPassword == correctPassword)
                {
                    loggedInUsername = enteredUsername;

                    WelcomeForm welcomeForm = new WelcomeForm(loggedInUsername);
                    this.Hide();
                    welcomeForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Warning!");
                    txtUsername.Focus();
                    txtUsername.SelectAll();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!");
            }
        }

        private void label1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
