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
    public partial class ITSupportTeamForm : Form
    {
        public ITSupportTeamForm()
        {
            InitializeComponent();
        }

        private void btnSolveTicket_Click(object sender, EventArgs e)
        {
            SolveTicketForm solveticketform = new SolveTicketForm();
            solveticketform.Show();
        }

        private void btnShareTickets_Click(object sender, EventArgs e)
        {
            TicketInfo ticketinfo = new TicketInfo();
            ticketinfo.Show();
        }

        private void Logoutlnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();

        }
    }
}
