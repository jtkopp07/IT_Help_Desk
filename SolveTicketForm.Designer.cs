namespace LoginAndRegister
{
    partial class SolveTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolveTicketForm));
            SolveTicketchklst = new CheckedListBox();
            SolveTicketbtn = new Button();
            SuspendLayout();
            // 
            // SolveTicketchklst
            // 
            SolveTicketchklst.FormattingEnabled = true;
            SolveTicketchklst.Location = new Point(140, 66);
            SolveTicketchklst.Name = "SolveTicketchklst";
            SolveTicketchklst.Size = new Size(407, 184);
            SolveTicketchklst.TabIndex = 0;
            // 
            // SolveTicketbtn
            // 
            SolveTicketbtn.Location = new Point(283, 282);
            SolveTicketbtn.Name = "SolveTicketbtn";
            SolveTicketbtn.Size = new Size(122, 40);
            SolveTicketbtn.TabIndex = 1;
            SolveTicketbtn.Text = "Confirm";
            SolveTicketbtn.UseVisualStyleBackColor = true;
            SolveTicketbtn.Click += SolveTicketbtn_Click;
            // 
            // SolveTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(SolveTicketbtn);
            Controls.Add(SolveTicketchklst);
            Name = "SolveTicketForm";
            Text = "SolveTicketForm";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox SolveTicketchklst;
        private Button SolveTicketbtn;
    }
}