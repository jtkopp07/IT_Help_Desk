namespace LoginAndRegister
{
    partial class HelpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            label1 = new Label();
            txtBoxHelpForm = new TextBox();
            txtBoxTemporaryHelpForm = new TextBox();
            btnCloseHelpForm = new Button();
            btnOpenPDF = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(92, 66);
            label1.Name = "label1";
            label1.Size = new Size(491, 28);
            label1.TabIndex = 0;
            label1.Text = "You are here because you are looking for help";
            // 
            // txtBoxHelpForm
            // 
            txtBoxHelpForm.BackColor = SystemColors.InfoText;
            txtBoxHelpForm.ForeColor = SystemColors.HighlightText;
            txtBoxHelpForm.Location = new Point(241, 105);
            txtBoxHelpForm.Margin = new Padding(3, 2, 3, 2);
            txtBoxHelpForm.Multiline = true;
            txtBoxHelpForm.Name = "txtBoxHelpForm";
            txtBoxHelpForm.Size = new Size(201, 50);
            txtBoxHelpForm.TabIndex = 1;
            txtBoxHelpForm.Text = "Welcome to the Official Help Form for our IT support. ";
            // 
            // txtBoxTemporaryHelpForm
            // 
            txtBoxTemporaryHelpForm.Location = new Point(207, 174);
            txtBoxTemporaryHelpForm.Margin = new Padding(3, 2, 3, 2);
            txtBoxTemporaryHelpForm.Name = "txtBoxTemporaryHelpForm";
            txtBoxTemporaryHelpForm.Size = new Size(273, 23);
            txtBoxTemporaryHelpForm.TabIndex = 2;
            txtBoxTemporaryHelpForm.Text = "For further assistance call us at +1 765 757 9442";
            // 
            // btnCloseHelpForm
            // 
            btnCloseHelpForm.Location = new Point(246, 279);
            btnCloseHelpForm.Margin = new Padding(3, 2, 3, 2);
            btnCloseHelpForm.Name = "btnCloseHelpForm";
            btnCloseHelpForm.Size = new Size(196, 44);
            btnCloseHelpForm.TabIndex = 3;
            btnCloseHelpForm.Text = "Click to Leave the Help Form";
            btnCloseHelpForm.UseVisualStyleBackColor = true;
            btnCloseHelpForm.Click += btnCloseHelpForm_Click;
            // 
            // btnOpenPDF
            // 
            btnOpenPDF.Location = new Point(282, 217);
            btnOpenPDF.Margin = new Padding(1);
            btnOpenPDF.Name = "btnOpenPDF";
            btnOpenPDF.Size = new Size(124, 47);
            btnOpenPDF.TabIndex = 4;
            btnOpenPDF.Text = "Open Help PDF";
            btnOpenPDF.UseVisualStyleBackColor = true;
            btnOpenPDF.Click += btnOpenPDF_Click;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(btnOpenPDF);
            Controls.Add(btnCloseHelpForm);
            Controls.Add(txtBoxTemporaryHelpForm);
            Controls.Add(txtBoxHelpForm);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HelpForm";
            Text = "HelpForm";
            Load += HelpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxHelpForm;
        private TextBox txtBoxTemporaryHelpForm;
        private Button btnCloseHelpForm;
        private Button btnOpenPDF;
    }
}
