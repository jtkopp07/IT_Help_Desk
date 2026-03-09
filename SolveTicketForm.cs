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
    public partial class SolveTicketForm : Form
    {
        public SolveTicketForm()
        {
            InitializeComponent();
            LoadIncompleteTickets();
        }
        private void LoadIncompleteTickets()
        {
            try
            {
                SolveTicketchklst.Items.Clear();

                var tickets = DBManager.CloseTicket();
                foreach (var ticket in tickets)
                {
                    SolveTicketchklst.Items.Add($"{ticket.TicketName} (Priority: {ticket.Priority}) | ID: {ticket.TicketID}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tickets: {ex.Message}", "Error");
            }
        }

        private void SolveTicketbtn_Click(object sender, EventArgs e)
        {
            if (SolveTicketchklst.SelectedItem == null)
            {
                MessageBox.Show("Please select a ticket from the list.", "Warning!");
                return;
            }

            string selectedText = SolveTicketchklst.SelectedItem.ToString();
            string ticketIDString = selectedText.Split('|').Last().Replace("ID: ", "").Trim();

            if (!int.TryParse(ticketIDString, out int ticketID))
            {
                MessageBox.Show("Invalid ticket selection.", "Error");
                return;
            }

            try
            {
                string newStatus = "Complete";
                DBManager.UpdateTicketStatus(ticketID, newStatus);
                MessageBox.Show($"Ticket '{selectedText}' status updated to '{newStatus}'.", "Success!");
                LoadIncompleteTickets(); // Refresh list after update
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update ticket status: {ex.Message}", "Error!");
            }
        }
    }
}
