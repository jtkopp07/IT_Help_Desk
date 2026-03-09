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
    public partial class ProblemListForm : Form
    {
        public ProblemListForm()
        {
            InitializeComponent();
            LoadTickets();
        }
        private void LoadTickets()
        {
            try
            {
                List<DBManager.Ticket> tickets = DBManager.GetAllTickets();
                foreach (var ticket in tickets)
                {
                    string ticketInfo = $"Ticket ID: {ticket.TicketID} Ticket Name: {ticket.TicketName} Ticket Priority (1-10) {ticket.Priority} Valid User ID: ({ticket.ValidUserID})";
                    ExistingProblemlst.Items.Add(ticketInfo);  // Ticketlstbox is your ListBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tickets: {ex.Message}", "Error");
            }
        }
    }
}
