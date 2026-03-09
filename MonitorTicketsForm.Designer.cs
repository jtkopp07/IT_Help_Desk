namespace LoginAndRegister
{
    partial class MonitorTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorTicketsForm));
            Monitorchklst = new CheckedListBox();
            label1 = new Label();
            Prioritytxtbox = new TextBox();
            ConfrimPrioritybtn = new Button();
            SuspendLayout();
            // 
            // Monitorchklst
            // 
            Monitorchklst.FormattingEnabled = true;
            Monitorchklst.Location = new Point(184, 48);
            Monitorchklst.Name = "Monitorchklst";
            Monitorchklst.Size = new Size(312, 202);
            Monitorchklst.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 278);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 1;
            label1.Text = "Please Enter a Priority (1-10)";
            // 
            // Prioritytxtbox
            // 
            Prioritytxtbox.Location = new Point(295, 271);
            Prioritytxtbox.Name = "Prioritytxtbox";
            Prioritytxtbox.Size = new Size(100, 23);
            Prioritytxtbox.TabIndex = 2;
            // 
            // ConfrimPrioritybtn
            // 
            ConfrimPrioritybtn.Location = new Point(421, 270);
            ConfrimPrioritybtn.Name = "ConfrimPrioritybtn";
            ConfrimPrioritybtn.Size = new Size(75, 23);
            ConfrimPrioritybtn.TabIndex = 3;
            ConfrimPrioritybtn.Text = "Confirm";
            ConfrimPrioritybtn.UseVisualStyleBackColor = true;
            ConfrimPrioritybtn.Click += ConfrimPrioritybtn_Click;
            // 
            // MonitorTicketsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(ConfrimPrioritybtn);
            Controls.Add(Prioritytxtbox);
            Controls.Add(label1);
            Controls.Add(Monitorchklst);
            Name = "MonitorTicketsForm";
            Text = "Monitor Tickets Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox Monitorchklst;
        private Label label1;
        private TextBox Prioritytxtbox;
        private Button ConfrimPrioritybtn;
    }
}