namespace LoginAndRegister
{
    partial class TicketInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketInfo));
            Ticketlstbox = new ListBox();
            Generate_Descriptionbtn = new Button();
            SendEmailbtn = new Button();
            Emailtxt = new TextBox();
            SuspendLayout();
            // 
            // Ticketlstbox
            // 
            Ticketlstbox.FormattingEnabled = true;
            Ticketlstbox.ItemHeight = 15;
            Ticketlstbox.Location = new Point(95, 71);
            Ticketlstbox.Name = "Ticketlstbox";
            Ticketlstbox.Size = new Size(478, 184);
            Ticketlstbox.TabIndex = 0;
            // 
            // Generate_Descriptionbtn
            // 
            Generate_Descriptionbtn.Location = new Point(135, 289);
            Generate_Descriptionbtn.Name = "Generate_Descriptionbtn";
            Generate_Descriptionbtn.Size = new Size(163, 33);
            Generate_Descriptionbtn.TabIndex = 1;
            Generate_Descriptionbtn.Text = "Generate Description";
            Generate_Descriptionbtn.UseVisualStyleBackColor = true;
            Generate_Descriptionbtn.Click += Generate_Descriptionbtn_Click;
            // 
            // SendEmailbtn
            // 
            SendEmailbtn.Location = new Point(318, 289);
            SendEmailbtn.Name = "SendEmailbtn";
            SendEmailbtn.Size = new Size(91, 33);
            SendEmailbtn.TabIndex = 2;
            SendEmailbtn.Text = "Send Email";
            SendEmailbtn.UseVisualStyleBackColor = true;
            SendEmailbtn.Click += SendEmailbtn_Click_1;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(415, 299);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(100, 23);
            Emailtxt.TabIndex = 3;
            // 
            // TicketInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(Emailtxt);
            Controls.Add(SendEmailbtn);
            Controls.Add(Generate_Descriptionbtn);
            Controls.Add(Ticketlstbox);
            Name = "TicketInfo";
            Text = "TicketInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Ticketlstbox;
        private Button Generate_Descriptionbtn;
        private Button SendEmailbtn;
        private TextBox Emailtxt;
    }
}