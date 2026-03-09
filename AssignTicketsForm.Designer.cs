namespace LoginAndRegister
{
    partial class AssignTicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTicketsForm));
            Ticketlst = new CheckedListBox();
            Userlist = new CheckedListBox();
            AssignTicketsbtn = new Button();
            SuspendLayout();
            // 
            // Ticketlst
            // 
            Ticketlst.FormattingEnabled = true;
            Ticketlst.Location = new Point(12, 83);
            Ticketlst.Name = "Ticketlst";
            Ticketlst.Size = new Size(317, 166);
            Ticketlst.TabIndex = 0;
            Ticketlst.SelectedIndexChanged += Ticketlst_SelectedIndexChanged;
            // 
            // Userlist
            // 
            Userlist.FormattingEnabled = true;
            Userlist.Location = new Point(347, 83);
            Userlist.Name = "Userlist";
            Userlist.Size = new Size(317, 166);
            Userlist.TabIndex = 1;
            // 
            // AssignTicketsbtn
            // 
            AssignTicketsbtn.Location = new Point(299, 277);
            AssignTicketsbtn.Name = "AssignTicketsbtn";
            AssignTicketsbtn.Size = new Size(96, 45);
            AssignTicketsbtn.TabIndex = 2;
            AssignTicketsbtn.Text = "Assign";
            AssignTicketsbtn.UseVisualStyleBackColor = true;
            AssignTicketsbtn.Click += AssignTicketsbtn_Click;
            // 
            // AssignTicketsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(AssignTicketsbtn);
            Controls.Add(Userlist);
            Controls.Add(Ticketlst);
            Name = "AssignTicketsForm";
            Text = "AssignTicketsForm";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox Ticketlst;
        private CheckedListBox Userlist;
        private Button AssignTicketsbtn;
    }
}