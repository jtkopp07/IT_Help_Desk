using System;
using System.Windows.Forms;
using static LoginAndRegister.DBManager;

namespace LoginAndRegister
{
    public partial class AssignTicketsForm : Form
    {
        public AssignTicketsForm()
        {
            InitializeComponent();
            LoadTicketLists();
        }

        private void AssignTicketsbtn_Click(object sender, EventArgs e)
        {
            if (Ticketlst.SelectedItem == null || Userlist.SelectedItem == null)
            {
                MessageBox.Show("Please select both a ticket and a user.", "Warning!");
                return;
            }

            try
            {
                string selectedTicketString = Ticketlst.SelectedItem.ToString();
                string ticketIDString = ExtractIDFromText(selectedTicketString);
                int selectedTicket = int.Parse(ticketIDString);

                string selectedUserString = Userlist.SelectedItem.ToString();
                string userIDString = ExtractIDFromText(selectedUserString);
                int selectedUser = int.Parse(userIDString);

                DBManager.AssignTicketToUser(selectedTicket, selectedUser);
                MessageBox.Show($"Ticket has been successfully assigned to the user.", "Success!");

                LoadTicketLists();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid format. Ensure proper selection from the list: {ex.Message}", "Error!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!");
            }
        }

        private string ExtractIDFromText(string text)
        {
            text = text.Trim();

            int idIndex = text.IndexOf("ID:");

            if (idIndex == -1)
            {
                throw new FormatException("Unable to find ID in the provided text.");
            }

            string idString = text.Substring(idIndex + 3).Trim();

            int separatorIndex = idString.IndexOf(" ");

            if (separatorIndex != -1)
            {
                idString = idString.Substring(0, separatorIndex).Trim();
            }

            return idString;
        }




        public void LoadTicketLists()
        {
            try
            {
                Ticketlst.Items.Clear();
                Userlist.Items.Clear();

                var tickets = DBManager.GetAllTickets();
                foreach (var ticket in tickets)
                {
                    Ticketlst.Items.Add($"{ticket.TicketName} (Priority: {ticket.Priority}) | ID: {ticket.TicketID}");
                }

                var users = DBManager.GetAllUsers();
                foreach (var user in users)
                {
                    Userlist.Items.Add($"{user.UserName} (Password: {user.Password}) | Role: {user.Role} ID: {user.UserID}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tickets and users: {ex.Message}", "Error");
            }
        }

        private void Ticketlst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
