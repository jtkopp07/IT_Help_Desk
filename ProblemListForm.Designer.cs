namespace LoginAndRegister
{
    partial class ProblemListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemListForm));
            ExistingProblemlst = new ListBox();
            SuspendLayout();
            // 
            // ExistingProblemlst
            // 
            ExistingProblemlst.FormattingEnabled = true;
            ExistingProblemlst.ItemHeight = 15;
            ExistingProblemlst.Location = new Point(143, 67);
            ExistingProblemlst.Name = "ExistingProblemlst";
            ExistingProblemlst.Size = new Size(441, 229);
            ExistingProblemlst.TabIndex = 0;
            // 
            // ProblemListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(ExistingProblemlst);
            Name = "ProblemListForm";
            Text = "ProblemListForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ExistingProblemlst;
    }
}