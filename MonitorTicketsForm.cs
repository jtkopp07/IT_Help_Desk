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
    public partial class MonitorTicketsForm : Form
    {
        public MonitorTicketsForm()
        {
            InitializeComponent();
            LoadTickets();
        }

        private void ConfrimPrioritybtn_Click(object sender, EventArgs e)
{
    if (Monitorchklst.SelectedItem == null)
    {
        MessageBox.Show("Please select a ticket from the list.", "Warning!");
        return;
    }

    string selectedText = Monitorchklst.SelectedItem.ToString();
    string ticketIDString = selectedText.Split('|').Last().Replace("ID: ", "").Trim();

    if (string.IsNullOrWhiteSpace(Prioritytxtbox.Text))
    {
        MessageBox.Show("Please enter a priority", "Warning!");
        return;
    }

    try
    {
        string priority = Prioritytxtbox.Text;
        DBManager.AlterUrgency(ticketIDString, priority);
        MessageBox.Show($"Ticket '{selectedText}' priority updated to '{priority}'.", "Success!");
        LoadTickets(); // Refresh list after update
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Failed to update ticket priority: {ex.Message}", "Error!");
    }
}
        private void LoadTickets()
        {
            try
            {
                Monitorchklst.Items.Clear();

                var tickets = DBManager.GetAllTickets();
                foreach (var ticket in tickets)
                {
                    Monitorchklst.Items.Add($"{ticket.TicketName} (Priority: {ticket.Priority}) | ID: {ticket.TicketID}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tickets: {ex.Message}", "Error");
            }
        }


    }
}

