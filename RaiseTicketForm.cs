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
    public partial class RaiseTicketForm : Form
    {
        public RaiseTicketForm()
        {
            InitializeComponent();
        }

        private void GenerateTicketbtnm_Click(object sender, EventArgs e)
        {
            {
                string ticketname = TicketNametxt.Text;
                string priority = Prioritytxt.Text;
                string description = TicketDesctxt.Text;

                if (string.IsNullOrWhiteSpace(ticketname) || string.IsNullOrWhiteSpace(priority) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please fill in all of the boxes");
                    return;
                }



                if (DBManager.SaveTicket(ticketname, priority, description))
                {
                    MessageBox.Show("Ticket Saved");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while saving ticket data. Please try again.");
                }
            }
    }
}
}
    

