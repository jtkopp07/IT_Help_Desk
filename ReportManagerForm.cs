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
    public partial class ReportManagerForm : Form
    {
        public ReportManagerForm()
        {
            InitializeComponent();
        }

        private void btnMonitorTickets_Click(object sender, EventArgs e)
        {
            MonitorTicketsForm monitorticketsform = new MonitorTicketsForm();
            monitorticketsform.Show();
        }

        private void btnAssignTickets_Click(object sender, EventArgs e)
        {
            AssignTicketsForm assignticketsform = new AssignTicketsForm();
            assignticketsform.Show();
        }

        private void Logoutlnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();

        }
    }
}
