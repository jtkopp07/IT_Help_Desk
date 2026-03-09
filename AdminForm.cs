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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AssignRoles_Click(object sender, EventArgs e)
        {
            AssignRolesForm assignroles = new AssignRolesForm();
            assignroles.Show();
        }

        private void Ticket_Info_Click(object sender, EventArgs e)
        {
            TicketInfo ticketinfo = new TicketInfo();
            ticketinfo.Show();
        }

        private void logoutlnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();

        }
    }
}
