namespace LoginAndRegister
{
    partial class ReportManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportManagerForm));
            btnMonitorTickets = new Button();
            btnAssignTickets = new Button();
            Logoutlnklbl = new LinkLabel();
            SuspendLayout();
            // 
            // btnMonitorTickets
            // 
            btnMonitorTickets.Location = new Point(150, 157);
            btnMonitorTickets.Margin = new Padding(1);
            btnMonitorTickets.Name = "btnMonitorTickets";
            btnMonitorTickets.Size = new Size(158, 64);
            btnMonitorTickets.TabIndex = 0;
            btnMonitorTickets.Text = "Monitor Tickets";
            btnMonitorTickets.UseVisualStyleBackColor = true;
            btnMonitorTickets.Click += btnMonitorTickets_Click;
            // 
            // btnAssignTickets
            // 
            btnAssignTickets.Location = new Point(370, 157);
            btnAssignTickets.Margin = new Padding(1);
            btnAssignTickets.Name = "btnAssignTickets";
            btnAssignTickets.Size = new Size(158, 64);
            btnAssignTickets.TabIndex = 1;
            btnAssignTickets.Text = "Assign Tickets";
            btnAssignTickets.UseVisualStyleBackColor = true;
            btnAssignTickets.Click += btnAssignTickets_Click;
            // 
            // Logoutlnklbl
            // 
            Logoutlnklbl.AutoSize = true;
            Logoutlnklbl.BackColor = Color.Transparent;
            Logoutlnklbl.Location = new Point(12, 299);
            Logoutlnklbl.Name = "Logoutlnklbl";
            Logoutlnklbl.Size = new Size(45, 15);
            Logoutlnklbl.TabIndex = 2;
            Logoutlnklbl.TabStop = true;
            Logoutlnklbl.Text = "Logout";
            Logoutlnklbl.LinkClicked += Logoutlnklbl_LinkClicked;
            // 
            // ReportManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(Logoutlnklbl);
            Controls.Add(btnAssignTickets);
            Controls.Add(btnMonitorTickets);
            Margin = new Padding(1);
            Name = "ReportManagerForm";
            Text = "ReportManagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMonitorTickets;
        private Button btnAssignTickets;
        private LinkLabel Logoutlnklbl;
    }
}