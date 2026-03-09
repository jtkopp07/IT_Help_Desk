using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LoginAndRegister
{
    public partial class TicketInfo : Form
    {
        public TicketInfo()
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
                    Ticketlstbox.Items.Add(ticketInfo);  // Ticketlstbox is your ListBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tickets: {ex.Message}", "Error");
            }
        }

        // Generate Description button click event
        private void Generate_Descriptionbtn_Click(object sender, EventArgs e)
        {
            if (Ticketlstbox.SelectedItem != null)
            {
                try
                {
                    // Extract Ticket_ID from the selected item (assuming the format includes the ID first)
                    string selectedItem = Ticketlstbox.SelectedItem.ToString();
                    string ticketId = selectedItem.Split(' ')[2]; // Adjust based on the exact format

                    // Fetch and display the description
                    string description = DBManager.GetDescription(ticketId);
                    MessageBox.Show(description, "Ticket Description");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error generating description: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("Nothing Selected", "Warning");
            }
        }

        // Send Email button click event
        

        // Method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void SendEmailbtn_Click_1(object sender, EventArgs e)
        {
            if (Ticketlstbox.SelectedItem != null)
            {
                try
                {
                    // Extract Ticket_ID from the selected item
                    string selectedItem = Ticketlstbox.SelectedItem.ToString();
                    string ticketId = selectedItem.Split(' ')[2]; // Adjust based on the exact format

                    // Get the description for the selected ticket
                    string description = DBManager.GetDescription(ticketId);

                    // Get the email address from the TextBox
                    string email = Emailtxt.Text;

                    // Check if email is valid before sending
                    if (IsValidEmail(email))
                    {
                        // Call the SendEmail method from EmailGeneration class
                        EmailGeneration.SendEmail(email, ticketId, description);
                        MessageBox.Show("Email Sent");


                    }
                    else
                    {
                        MessageBox.Show("Invalid email address.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending email: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("No ticket selected.", "Warning");
            }
        }
    }
}

