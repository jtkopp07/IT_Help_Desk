using System;
using System.Windows.Forms;
using LoginAndRegister;

namespace LoginForm
{
    public partial class WelcomeForm : Form
    {
        private string loggedInUsername;

        public WelcomeForm(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            GrantAccess("Admin");
        }

        private void Project_Mananger_btn_Click(object sender, EventArgs e)
        {
            GrantAccess("Project Member");
        }

        private void IT_Support_Team_btn_Click(object sender, EventArgs e)
        {
            GrantAccess("IT Support Team");
        }

        private void Report_Manager_btn_Click(object sender, EventArgs e)
        {
            GrantAccess("Report Manager");
        }

        private void GrantAccess(string role)
        {
            if (DBManager.UserHasRole(loggedInUsername, role))
            {

                switch (role)
                {
                    case "Admin":
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                        break;

                    case "Project Member":
                        ProjectMemberForm projectmember = new ProjectMemberForm();
                        projectmember.Show();
                        this.Hide();
                        break;

                    case "IT Support Team":
                        ITSupportTeamForm itSupportTeam = new ITSupportTeamForm();
                        itSupportTeam.Show();
                        this.Hide();
                        break;

                    case "Report Manager":
                        ReportManagerForm reportManager = new ReportManagerForm();
                        reportManager.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Sorry, you are not authorized to view this.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Logoutlnklbl_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();

        }
    }
}
