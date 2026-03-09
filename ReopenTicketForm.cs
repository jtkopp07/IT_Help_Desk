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
    public partial class ReopenTicketForm : Form
    {
        public ReopenTicketForm()
        {
            InitializeComponent();
            LoadCompletedTickets();

        }
        private void LoadCompletedTickets()
        {
            try
            {
                CompletedTicketchklst.Items.Clear();

                var tickets = DBManager.ReopenTicket();
                foreach (var ticket in tickets)
                {
                    CompletedTicketchklst.Items.Add($"{ticket.TicketName} (Priority: {ticket.Priority}) | ID: {ticket.TicketID}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tickets: {ex.Message}", "Error");
            }
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            if (CompletedTicketchklst.SelectedItem == null)
            {
                MessageBox.Show("Please select a ticket from the list.", "Warning!");
                return;
            }

            string selectedText = CompletedTicketchklst.SelectedItem.ToString();
            string ticketIDString = selectedText.Split('|').Last().Replace("ID: ", "").Trim();

            if (!int.TryParse(ticketIDString, out int ticketID))
            {
                MessageBox.Show("Invalid ticket selection.", "Error");
                return;
            }

            try
            {
                string newStatus = "Pending";
                DBManager.UpdateTicketStatus(ticketID, newStatus);
                MessageBox.Show($"Ticket '{selectedText}' status updated to '{newStatus}'.", "Success!");
                LoadCompletedTickets(); // Refresh list after update
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update ticket status: {ex.Message}", "Error!");
            }
        }
    }
}