namespace LoginAndRegister
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            labelNewUsername = new Label();
            labelNewPassword = new Label();
            labelConfirmNewPassword = new Label();
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmNewPassword = new TextBox();
            btnRegister = new Button();
            label2 = new Label();
            helpProvider1 = new HelpProvider();
            helpProvider2 = new HelpProvider();
            helpProvider3 = new HelpProvider();
            SuspendLayout();
            // 
            // labelNewUsername
            // 
            labelNewUsername.AutoSize = true;
            labelNewUsername.BackColor = Color.Transparent;
            labelNewUsername.Location = new Point(103, 143);
            labelNewUsername.Name = "labelNewUsername";
            labelNewUsername.Size = new Size(86, 15);
            labelNewUsername.TabIndex = 0;
            labelNewUsername.Text = "New username";
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.BackColor = Color.Transparent;
            labelNewPassword.Location = new Point(103, 175);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(84, 15);
            labelNewPassword.TabIndex = 1;
            labelNewPassword.Text = "New password";
            // 
            // labelConfirmNewPassword
            // 
            labelConfirmNewPassword.AutoSize = true;
            labelConfirmNewPassword.BackColor = Color.Transparent;
            labelConfirmNewPassword.Location = new Point(103, 219);
            labelConfirmNewPassword.Name = "labelConfirmNewPassword";
            labelConfirmNewPassword.Size = new Size(104, 15);
            labelConfirmNewPassword.TabIndex = 2;
            labelConfirmNewPassword.Text = "Confirm password";
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(222, 140);
            txtNewUsername.Margin = new Padding(3, 2, 3, 2);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(145, 23);
            txtNewUsername.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(222, 175);
            txtNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(145, 23);
            txtNewPassword.TabIndex = 4;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(222, 211);
            txtConfirmNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(145, 23);
            txtConfirmNewPassword.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(235, 273);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(184, 31);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 70);
            label2.Name = "label2";
            label2.Size = new Size(322, 29);
            label2.TabIndex = 7;
            label2.Text = "Help Desk registration ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewUsername);
            Controls.Add(labelConfirmNewPassword);
            Controls.Add(labelNewPassword);
            Controls.Add(labelNewUsername);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNewUsername;
        private Label labelNewPassword;
        private Label labelConfirmNewPassword;
        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private TextBox txtConfirmNewPassword;
        private Button btnRegister;
        private Label label2;
        private HelpProvider helpProvider1;
        private HelpProvider helpProvider2;
        private HelpProvider helpProvider3;
    }
}