namespace LoginAndRegister
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            AssignRoles = new Button();
            Ticket_Info = new Button();
            logoutlnklbl = new LinkLabel();
            SuspendLayout();
            // 
            // AssignRoles
            // 
            AssignRoles.Location = new Point(161, 146);
            AssignRoles.Name = "AssignRoles";
            AssignRoles.Size = new Size(158, 64);
            AssignRoles.TabIndex = 0;
            AssignRoles.Text = "Assign Roles";
            AssignRoles.UseVisualStyleBackColor = true;
            AssignRoles.Click += AssignRoles_Click;
            // 
            // Ticket_Info
            // 
            Ticket_Info.Location = new Point(380, 146);
            Ticket_Info.Name = "Ticket_Info";
            Ticket_Info.Size = new Size(158, 64);
            Ticket_Info.TabIndex = 1;
            Ticket_Info.Text = "Report Generation";
            Ticket_Info.UseVisualStyleBackColor = true;
            Ticket_Info.Click += Ticket_Info_Click;
            // 
            // logoutlnklbl
            // 
            logoutlnklbl.AutoSize = true;
            logoutlnklbl.BackColor = Color.Transparent;
            logoutlnklbl.Location = new Point(12, 285);
            logoutlnklbl.Name = "logoutlnklbl";
            logoutlnklbl.Size = new Size(45, 15);
            logoutlnklbl.TabIndex = 2;
            logoutlnklbl.TabStop = true;
            logoutlnklbl.Text = "Logout";
            logoutlnklbl.LinkClicked += logoutlnklbl_LinkClicked;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(logoutlnklbl);
            Controls.Add(Ticket_Info);
            Controls.Add(AssignRoles);
            Name = "AdminForm";
            Text = "Admin Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AssignRoles;
        private Button Ticket_Info;
        private LinkLabel logoutlnklbl;
    }
}