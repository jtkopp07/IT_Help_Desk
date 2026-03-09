namespace LoginAndRegister
{
    partial class ReopenTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReopenTicketForm));
            CompletedTicketchklst = new CheckedListBox();
            Confirmbtn = new Button();
            SuspendLayout();
            // 
            // CompletedTicketchklst
            // 
            CompletedTicketchklst.FormattingEnabled = true;
            CompletedTicketchklst.Location = new Point(134, 70);
            CompletedTicketchklst.Name = "CompletedTicketchklst";
            CompletedTicketchklst.Size = new Size(407, 184);
            CompletedTicketchklst.TabIndex = 0;
            // 
            // Confirmbtn
            // 
            Confirmbtn.Location = new Point(282, 282);
            Confirmbtn.Name = "Confirmbtn";
            Confirmbtn.Size = new Size(122, 40);
            Confirmbtn.TabIndex = 1;
            Confirmbtn.Text = "Confirm Button";
            Confirmbtn.UseVisualStyleBackColor = true;
            Confirmbtn.Click += Confirmbtn_Click;
            // 
            // ReopenTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(Confirmbtn);
            Controls.Add(CompletedTicketchklst);
            Name = "ReopenTicketForm";
            Text = "Reopen Ticket Form";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox CompletedTicketchklst;
        private Button Confirmbtn;
    }
}