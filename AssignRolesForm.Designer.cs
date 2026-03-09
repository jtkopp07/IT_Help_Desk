
namespace LoginAndRegister
{
    partial class AssignRolesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignRolesForm));
            UsercheckedListBox = new CheckedListBox();
            Confirmbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            Adminbtn = new RadioButton();
            ProjectMemberbtn = new RadioButton();
            IT_Support_Teambtn = new RadioButton();
            Report_Managerbtn = new RadioButton();
            SuspendLayout();
            // 
            // UsercheckedListBox
            // 
            UsercheckedListBox.FormattingEnabled = true;
            UsercheckedListBox.Location = new Point(250, 62);
            UsercheckedListBox.Name = "UsercheckedListBox";
            UsercheckedListBox.Size = new Size(331, 238);
            UsercheckedListBox.TabIndex = 0;
            UsercheckedListBox.SelectedIndexChanged += UsercheckedListBox_SelectedIndexChanged;
            // 
            // Confirmbtn
            // 
            Confirmbtn.Location = new Point(114, 277);
            Confirmbtn.Name = "Confirmbtn";
            Confirmbtn.Size = new Size(75, 23);
            Confirmbtn.TabIndex = 1;
            Confirmbtn.Text = "Confirm";
            Confirmbtn.UseVisualStyleBackColor = true;
            Confirmbtn.Click += Confirmbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 285);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 106);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Select Role Here:";
            // 
            // Adminbtn
            // 
            Adminbtn.AutoSize = true;
            Adminbtn.Location = new Point(114, 148);
            Adminbtn.Name = "Adminbtn";
            Adminbtn.Size = new Size(61, 19);
            Adminbtn.TabIndex = 5;
            Adminbtn.TabStop = true;
            Adminbtn.Text = "Admin";
            Adminbtn.UseVisualStyleBackColor = true;
            // 
            // ProjectMemberbtn
            // 
            ProjectMemberbtn.AutoSize = true;
            ProjectMemberbtn.Location = new Point(114, 173);
            ProjectMemberbtn.Name = "ProjectMemberbtn";
            ProjectMemberbtn.Size = new Size(110, 19);
            ProjectMemberbtn.TabIndex = 6;
            ProjectMemberbtn.TabStop = true;
            ProjectMemberbtn.Text = "Project Member";
            ProjectMemberbtn.UseVisualStyleBackColor = true;
            // 
            // IT_Support_Teambtn
            // 
            IT_Support_Teambtn.AutoSize = true;
            IT_Support_Teambtn.Location = new Point(114, 198);
            IT_Support_Teambtn.Name = "IT_Support_Teambtn";
            IT_Support_Teambtn.Size = new Size(112, 19);
            IT_Support_Teambtn.TabIndex = 7;
            IT_Support_Teambtn.TabStop = true;
            IT_Support_Teambtn.Text = "IT Support Team";
            IT_Support_Teambtn.UseVisualStyleBackColor = true;
            // 
            // Report_Managerbtn
            // 
            Report_Managerbtn.AutoSize = true;
            Report_Managerbtn.Location = new Point(114, 223);
            Report_Managerbtn.Name = "Report_Managerbtn";
            Report_Managerbtn.Size = new Size(110, 19);
            Report_Managerbtn.TabIndex = 8;
            Report_Managerbtn.TabStop = true;
            Report_Managerbtn.Text = "Report Manager";
            Report_Managerbtn.UseVisualStyleBackColor = true;
            // 
            // AssignRolesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 334);
            Controls.Add(Report_Managerbtn);
            Controls.Add(IT_Support_Teambtn);
            Controls.Add(ProjectMemberbtn);
            Controls.Add(Adminbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Confirmbtn);
            Controls.Add(UsercheckedListBox);
            Name = "AssignRolesForm";
            Text = "Assign Roles Form";
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private CheckedListBox UsercheckedListBox;
        private Button Confirmbtn;
        private Label label1;
        private Label label2;
        private RadioButton Adminbtn;
        private RadioButton ProjectMemberbtn;
        private RadioButton IT_Support_Teambtn;
        private RadioButton Report_Managerbtn;
    }
}