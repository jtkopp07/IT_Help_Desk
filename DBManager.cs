using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginAndRegister
{
    internal class DBManager
    {
        // Jack DB Link
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; 
                                                             AttachDbFilename=C:\Users\labuser\source\repos\gbeblo\J.F.G.H\Register.mdf; 
                                                             Integrated Security=True; Connect Timeout=30;";

        // Harry DB Link
        /*
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; 
                                                             AttachDbFilename=C:\Users\labuser\source\repos\J.F.G.H\Register.mdf; 
                                                             Integrated Security=True; Connect Timeout=30;"; */

        // Check if a user exists in the database
        public static bool UserExists(string username)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Valid_User WHERE Valid_User_Name = @username", cn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking user existence: {ex.Message}", "Database Error");
                return false;
            }
        }

        // Save a new user to the database
        public static bool SaveUser(string username, string password)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(@"
                    DECLARE @NewUserID INT;
                    SET @NewUserID = (SELECT ISNULL(MAX(Valid_User_ID), 0) + 1 FROM Valid_User);
                    INSERT INTO Valid_User (Valid_User_ID, Valid_User_Name, Valid_User_Password, Valid_User_Role) 
                    VALUES (@NewUserID, @username, @password, 'User');", cn)) // Default role is "User"
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    cn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Database Error");
                return false;
            }
        }

        // Retrieve the user's password
        public static string GetUserPassword(string username)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT Valid_User_Password FROM Valid_User WHERE Valid_User_Name = @username", cn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return dr.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving password: {ex.Message}", "Database Error");
            }

            return null;
        }

        // Check if a user has a specific role
        public static bool UserHasRole(string username, string role)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT Valid_User_Role FROM Valid_User WHERE Valid_User_Name = @username", cn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return dr["Valid_User_Role"].ToString().Equals(role, StringComparison.OrdinalIgnoreCase);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking user role: {ex.Message}", "Database Error");
            }

            return false;
        }

        // Get all users and their roles
        public static List<UserInfo> GetAllUsersWithRoles()
        {
            var users = new List<UserInfo>();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT Valid_User_Name, Valid_User_Role FROM Valid_User", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            users.Add(new UserInfo
                            {
                                Username = dr["Valid_User_Name"].ToString(),
                                Role = dr["Valid_User_Role"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Database Error");
            }

            return users;
        }

        // Update the role of a specific user
        public static void UpdateUserRole(string username, string newRole)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("UPDATE Valid_User SET Valid_User_Role = @role WHERE Valid_User_Name = @username", cn))
                {
                    cmd.Parameters.AddWithValue("@role", newRole);
                    cmd.Parameters.AddWithValue("@username", username);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user role: {ex.Message}", "Database Error");
                throw;
            }
        }

        // Get all tickets from the Ticket table
        public static List<Ticket> GetAllTickets()
        {
            var tickets = new List<Ticket>();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT Ticket_ID, Ticket_Name, Priority, Valid_User_ID FROM Ticket", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tickets.Add(new Ticket
                            {
                                TicketID = dr["Ticket_ID"].ToString(),
                                TicketName = dr["Ticket_Name"].ToString(),
                                Priority = dr["Priority"].ToString(),
                                ValidUserID = dr["Valid_User_ID"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tickets: {ex.Message}", "Database Error");
            }

            return tickets;
        }
        public static List<User> GetAllUsers()
        {
            var user = new List<User>();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT Valid_User_ID, Valid_User_Name, Valid_User_Role, Valid_User_Password FROM Valid_User", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            user.Add(new User
                            {
                                UserName = dr["Valid_User_Name"].ToString(),
                                Role = dr["Valid_User_ID"].ToString(),
                                Password = dr["Valid_User_Password"].ToString(),
                                UserID = dr["Valid_User_ID"].ToString()
                            });
                        }
                    }
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show($"Error loading Users: {ex.Message}", "Database Error");
            }
            return user;
        }

        public static string GetDescription(string ticketId)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT Ticket_Description FROM Ticket WHERE Ticket_ID = @ticketid", cn))
                {
                    cmd.Parameters.AddWithValue("@ticketid", ticketId);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return dr["Ticket_Description"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving ticket description: {ex.Message}", "Database Error");
            }

            return "No description found.";
        }

            public static List<(string TicketName, string Priority, int TicketID)> ReopenTicket()
            {
                var tickets = new List<(string TicketName, string Priority, int TicketID)>();

                try
                {
                    using (SqlConnection cn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("SELECT Ticket_Name, Priority, Ticket_ID FROM Ticket WHERE Ticket_Status = 'Complete'", cn))
                    {
                        cn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string ticketName = dr["Ticket_Name"].ToString();
                                string priority = dr["Priority"].ToString();  
                                int ticketID = (int)dr["Ticket_ID"];  

                                tickets.Add((ticketName, priority, ticketID));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading tickets: {ex.Message}", "Database Error");
                }

                return tickets;
            }

        public static void UpdateTicketStatus(int ticketID, string newStatus)
        {
            try
            {
               
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("UPDATE Ticket SET Ticket_Status = @Status WHERE Ticket_ID = @TicketID", cn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@TicketID", ticketID);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating ticket status: {ex.Message}", "Database Error");
            }
        }
        public static bool SaveTicket(string ticketname, string priority,string description)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Ticket (Ticket_Name, Priority, Ticket_Description, Ticket_Status) VALUES (@ticketname, @priority, @description, 'Pending');", cn))
                    // Default role is "Pending"
                {
                    cmd.Parameters.AddWithValue("@ticketname", ticketname);
                    cmd.Parameters.AddWithValue("@priority", priority);
                    cmd.Parameters.AddWithValue("@description", description);

                    cn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Database Error");
                return false;
            }
        }
        public static List<(string TicketName, string Priority, int TicketID)> CloseTicket()
        {
            var tickets = new List<(string TicketName, string Priority, int TicketID)>();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT Ticket_Name, Priority, Ticket_ID FROM Ticket WHERE Ticket_Status = 'Pending'", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string ticketName = dr["Ticket_Name"].ToString();
                            string priority = dr["Priority"].ToString();
                            int ticketID = (int)dr["Ticket_ID"];

                            tickets.Add((ticketName, priority, ticketID));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tickets: {ex.Message}", "Database Error");
            }

            return tickets;
        }
        public static void AlterUrgency(string TicketID, string priority)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("UPDATE Ticket SET Priority = @priority WHERE Ticket_ID = @TicketID", cn))
                {
                    cmd.Parameters.AddWithValue("@priority", priority);
                    cmd.Parameters.AddWithValue("@TicketID", TicketID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user role: {ex.Message}", "Database Error");
                throw;
            }
        }
        public static void AssignTicketToUser(int userID, int ticketID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Assigned_Users (Valid_User_ID, Ticket_ID) VALUES (@UserID, @TicketID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@TicketID", ticketID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public struct UserInfo
        {
            public string Username;
            public string Role;
        }

        // Struct for holding ticket info
        public struct Ticket
        {
            public string TicketID;
            public string TicketName;
            public string Priority;
            public string ValidUserID;
        }
       



    }
}
    


    