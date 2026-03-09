using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegister
{
    public partial class ProjectMemberForm : Form
    {
        public ProjectMemberForm()
        {
            InitializeComponent();
        }

        private void btnOnlineHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void ProblemListbtn_Click(object sender, EventArgs e)
        {
            ProblemListForm problemlistform = new ProblemListForm();
            problemlistform.Show();

        }

        private void Raise_Ticketbtn_Click(object sender, EventArgs e)
        {
            RaiseTicketForm raiseticket = new RaiseTicketForm();
            raiseticket.Show();
        }

        private void ReopenTicketbtn_Click(object sender, EventArgs e)
        {
            ReopenTicketForm reopenticketform = new ReopenTicketForm();
            reopenticketform.Show();
        }

        private void ProjectMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void Logoutlnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();

        }
    }
}
    

