using System;
using System.Windows.Forms;

namespace LoginAndRegister
{
    public partial class AssignRolesForm : Form
    {
        public AssignRolesForm()
        {
            InitializeComponent();
            LoadUserList();
        }

        private void LoadUserList()
        {
            try
            {
                var users = DBManager.GetAllUsersWithRoles();
                UsercheckedListBox.Items.Clear();

                foreach (var user in users)
                {
                    UsercheckedListBox.Items.Add($"{user.Username} ({user.Role})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users: {ex.Message}", "Error");
            }
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            if (UsercheckedListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a user from the list.", "Warning!");
                return;
            }

            string selectedUser = UsercheckedListBox.SelectedItem.ToString().Split('(')[0].Trim();
            string newRole = GetSelectedRole();

            if (string.IsNullOrEmpty(newRole))
            {
                MessageBox.Show("Please select a role to assign.", "Warning!");
                return;
            }

            try
            {
                DBManager.UpdateUserRole(selectedUser, newRole);
                MessageBox.Show($"User '{selectedUser}' role updated to '{newRole}'.", "Success!");
                LoadUserList(); // Refresh list after update
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update role: {ex.Message}", "Error!");
            }
        }

        private string GetSelectedRole()
        {
            if (Adminbtn.Checked) return "Admin";
            if (ProjectMemberbtn.Checked) return "Project Member";
            if (IT_Support_Teambtn.Checked) return "IT Support Team";
            if (Report_Managerbtn.Checked) return "Report Manager";
            return string.Empty;
        }

        private void UsercheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // could pre-select role based on current user role
        }
    }
}
