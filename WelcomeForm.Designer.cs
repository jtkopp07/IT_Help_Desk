

namespace LoginForm
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            btnExit = new Button();
            Admin_btn = new Button();
            Project_Mananger_btn = new Button();
            IT_Support_Team_btn = new Button();
            Report_Manager_btn = new Button();
            textBox1 = new TextBox();
            Logoutlnklbl = new LinkLabel();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(290, 290);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 32);
            btnExit.TabIndex = 0;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Admin_btn
            // 
            Admin_btn.Location = new Point(24, 174);
            Admin_btn.Margin = new Padding(4, 3, 4, 3);
            Admin_btn.Name = "Admin_btn";
            Admin_btn.Size = new Size(158, 64);
            Admin_btn.TabIndex = 1;
            Admin_btn.Text = "Admin";
            Admin_btn.UseVisualStyleBackColor = true;
            Admin_btn.Click += Admin_btn_Click;
            // 
            // Project_Mananger_btn
            // 
            Project_Mananger_btn.Location = new Point(189, 174);
            Project_Mananger_btn.Name = "Project_Mananger_btn";
            Project_Mananger_btn.Size = new Size(158, 64);
            Project_Mananger_btn.TabIndex = 2;
            Project_Mananger_btn.Text = "Project Member";
            Project_Mananger_btn.UseVisualStyleBackColor = true;
            Project_Mananger_btn.Click += Project_Mananger_btn_Click;
            // 
            // IT_Support_Team_btn
            // 
            IT_Support_Team_btn.Location = new Point(353, 174);
            IT_Support_Team_btn.Name = "IT_Support_Team_btn";
            IT_Support_Team_btn.Size = new Size(158, 64);
            IT_Support_Team_btn.TabIndex = 3;
            IT_Support_Team_btn.Text = "IT Support Team";
            IT_Support_Team_btn.UseVisualStyleBackColor = true;
            IT_Support_Team_btn.Click += IT_Support_Team_btn_Click;
            // 
            // Report_Manager_btn
            // 
            Report_Manager_btn.Location = new Point(517, 174);
            Report_Manager_btn.Name = "Report_Manager_btn";
            Report_Manager_btn.Size = new Size(158, 64);
            Report_Manager_btn.TabIndex = 4;
            Report_Manager_btn.Text = "Report Manager";
            Report_Manager_btn.UseVisualStyleBackColor = true;
            Report_Manager_btn.Click += Report_Manager_btn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 104);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Welcome to our page, Please choose your role below ! ";
            // 
            // Logoutlnklbl
            // 
            Logoutlnklbl.AutoSize = true;
            Logoutlnklbl.BackColor = Color.Transparent;
            Logoutlnklbl.ForeColor = Color.DarkRed;
            Logoutlnklbl.Location = new Point(26, 287);
            Logoutlnklbl.Name = "Logoutlnklbl";
            Logoutlnklbl.Size = new Size(45, 15);
            Logoutlnklbl.TabIndex = 6;
            Logoutlnklbl.TabStop = true;
            Logoutlnklbl.Text = "Logout";
            Logoutlnklbl.LinkClicked += Logoutlnklbl_LinkClicked_1;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(Logoutlnklbl);
            Controls.Add(textBox1);
            Controls.Add(Report_Manager_btn);
            Controls.Add(IT_Support_Team_btn);
            Controls.Add(Project_Mananger_btn);
            Controls.Add(Admin_btn);
            Controls.Add(btnExit);
            Margin = new Padding(4, 3, 4, 3);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button Admin_btn;
        private Button Project_Mananger_btn;
        private Button IT_Support_Team_btn;
        private Button Report_Manager_btn;
        private TextBox textBox1;
        private LinkLabel Logoutlnklbl;
    }
}