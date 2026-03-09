namespace LoginAndRegister
{
    partial class ITSupportTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITSupportTeamForm));
            btnSolveTicket = new Button();
            btnShareTickets = new Button();
            Logoutlnklbl = new LinkLabel();
            SuspendLayout();
            // 
            // btnSolveTicket
            // 
            btnSolveTicket.Anchor = AnchorStyles.None;
            btnSolveTicket.Location = new Point(162, 141);
            btnSolveTicket.Margin = new Padding(1);
            btnSolveTicket.Name = "btnSolveTicket";
            btnSolveTicket.Size = new Size(158, 64);
            btnSolveTicket.TabIndex = 0;
            btnSolveTicket.Text = "Solve Ticket";
            btnSolveTicket.UseVisualStyleBackColor = true;
            btnSolveTicket.Click += btnSolveTicket_Click;
            // 
            // btnShareTickets
            // 
            btnShareTickets.Anchor = AnchorStyles.None;
            btnShareTickets.Location = new Point(358, 141);
            btnShareTickets.Margin = new Padding(1);
            btnShareTickets.Name = "btnShareTickets";
            btnShareTickets.Size = new Size(158, 64);
            btnShareTickets.TabIndex = 1;
            btnShareTickets.Text = "Share Ticket";
            btnShareTickets.UseVisualStyleBackColor = true;
            btnShareTickets.Click += btnShareTickets_Click;
            // 
            // Logoutlnklbl
            // 
            Logoutlnklbl.AutoSize = true;
            Logoutlnklbl.BackColor = Color.Transparent;
            Logoutlnklbl.Location = new Point(12, 304);
            Logoutlnklbl.Name = "Logoutlnklbl";
            Logoutlnklbl.Size = new Size(45, 15);
            Logoutlnklbl.TabIndex = 2;
            Logoutlnklbl.TabStop = true;
            Logoutlnklbl.Text = "Logout";
            Logoutlnklbl.LinkClicked += Logoutlnklbl_LinkClicked;
            // 
            // ITSupportTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(697, 334);
            Controls.Add(Logoutlnklbl);
            Controls.Add(btnShareTickets);
            Controls.Add(btnSolveTicket);
            Margin = new Padding(1);
            Name = "ITSupportTeamForm";
            Text = "ITSupportTeamForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolveTicket;
        private Button btnShareTickets;
        private LinkLabel Logoutlnklbl;
    }
}