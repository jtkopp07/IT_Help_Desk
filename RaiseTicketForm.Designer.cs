namespace LoginAndRegister
{
    partial class RaiseTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaiseTicketForm));
            GenerateTicketbtnm = new Button();
            TicketName = new Label();
            label2 = new Label();
            label3 = new Label();
            TicketNametxt = new TextBox();
            Prioritytxt = new TextBox();
            TicketDesctxt = new TextBox();
            SuspendLayout();
            // 
            // GenerateTicketbtnm
            // 
            GenerateTicketbtnm.Location = new Point(219, 233);
            GenerateTicketbtnm.Name = "GenerateTicketbtnm";
            GenerateTicketbtnm.Size = new Size(101, 23);
            GenerateTicketbtnm.TabIndex = 0;
            GenerateTicketbtnm.Text = "Generate Ticket";
            GenerateTicketbtnm.UseVisualStyleBackColor = true;
            GenerateTicketbtnm.Click += GenerateTicketbtnm_Click;
            // 
            // TicketName
            // 
            TicketName.AutoSize = true;
            TicketName.Location = new Point(109, 90);
            TicketName.Name = "TicketName";
            TicketName.Size = new Size(77, 15);
            TicketName.TabIndex = 1;
            TicketName.Text = "Ticket Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 128);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Priority (1-10):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 167);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 3;
            label3.Text = "Ticket Description:";
            // 
            // TicketNametxt
            // 
            TicketNametxt.Location = new Point(220, 87);
            TicketNametxt.Name = "TicketNametxt";
            TicketNametxt.Size = new Size(100, 23);
            TicketNametxt.TabIndex = 4;
            // 
            // Prioritytxt
            // 
            Prioritytxt.Location = new Point(220, 128);
            Prioritytxt.Name = "Prioritytxt";
            Prioritytxt.Size = new Size(100, 23);
            Prioritytxt.TabIndex = 5;
            // 
            // TicketDesctxt
            // 
            TicketDesctxt.Location = new Point(220, 164);
            TicketDesctxt.Name = "TicketDesctxt";
            TicketDesctxt.Size = new Size(100, 23);
            TicketDesctxt.TabIndex = 6;
            // 
            // RaiseTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(TicketDesctxt);
            Controls.Add(Prioritytxt);
            Controls.Add(TicketNametxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TicketName);
            Controls.Add(GenerateTicketbtnm);
            Name = "RaiseTicketForm";
            Text = "Raise Ticket Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateTicketbtnm;
        private Label TicketName;
        private Label label2;
        private Label label3;
        private TextBox TicketNametxt;
        private TextBox Prioritytxt;
        private TextBox TicketDesctxt;
    }
}