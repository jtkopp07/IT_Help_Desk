namespace LoginAndRegister
{
    partial class ProjectMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMemberForm));
            btnOnlineHelp = new Button();
            ProblemListbtn = new Button();
            Raise_Ticketbtn = new Button();
            ReopenTicketbtn = new Button();
            Logoutlnklbl = new LinkLabel();
            SuspendLayout();
            // 
            // btnOnlineHelp
            // 
            btnOnlineHelp.Location = new Point(174, 113);
            btnOnlineHelp.Margin = new Padding(1);
            btnOnlineHelp.Name = "btnOnlineHelp";
            btnOnlineHelp.Size = new Size(158, 64);
            btnOnlineHelp.TabIndex = 0;
            btnOnlineHelp.Text = "Online Help";
            btnOnlineHelp.UseVisualStyleBackColor = true;
            btnOnlineHelp.Click += btnOnlineHelp_Click;
            // 
            // ProblemListbtn
            // 
            ProblemListbtn.Location = new Point(364, 113);
            ProblemListbtn.Name = "ProblemListbtn";
            ProblemListbtn.Size = new Size(158, 64);
            ProblemListbtn.TabIndex = 1;
            ProblemListbtn.Text = "Problem List";
            ProblemListbtn.UseVisualStyleBackColor = true;
            ProblemListbtn.Click += ProblemListbtn_Click;
            // 
            // Raise_Ticketbtn
            // 
            Raise_Ticketbtn.Location = new Point(364, 208);
            Raise_Ticketbtn.Name = "Raise_Ticketbtn";
            Raise_Ticketbtn.Size = new Size(158, 64);
            Raise_Ticketbtn.TabIndex = 2;
            Raise_Ticketbtn.Text = "Raise Ticket";
            Raise_Ticketbtn.UseVisualStyleBackColor = true;
            Raise_Ticketbtn.Click += Raise_Ticketbtn_Click;
            // 
            // ReopenTicketbtn
            // 
            ReopenTicketbtn.Location = new Point(174, 208);
            ReopenTicketbtn.Name = "ReopenTicketbtn";
            ReopenTicketbtn.Size = new Size(158, 64);
            ReopenTicketbtn.TabIndex = 3;
            ReopenTicketbtn.Text = "Re-Open Ticket";
            ReopenTicketbtn.UseVisualStyleBackColor = true;
            ReopenTicketbtn.Click += ReopenTicketbtn_Click;
            // 
            // Logoutlnklbl
            // 
            Logoutlnklbl.AutoSize = true;
            Logoutlnklbl.BackColor = Color.Transparent;
            Logoutlnklbl.Location = new Point(12, 313);
            Logoutlnklbl.Name = "Logoutlnklbl";
            Logoutlnklbl.Size = new Size(45, 15);
            Logoutlnklbl.TabIndex = 4;
            Logoutlnklbl.TabStop = true;
            Logoutlnklbl.Text = "Logout";
            Logoutlnklbl.LinkClicked += Logoutlnklbl_LinkClicked;
            // 
            // ProjectMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(Logoutlnklbl);
            Controls.Add(ReopenTicketbtn);
            Controls.Add(Raise_Ticketbtn);
            Controls.Add(ProblemListbtn);
            Controls.Add(btnOnlineHelp);
            Name = "ProjectMemberForm";
            Text = "Project Member Form";
            Load += ProjectMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOnlineHelp;
        private Button ProblemListbtn;
        private Button Raise_Ticketbtn;
        private Button ReopenTicketbtn;
        private LinkLabel Logoutlnklbl;
    }
}