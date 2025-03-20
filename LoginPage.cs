using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Student_Management_System;

namespace Student_Management_System 
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Query to check username and password from your `login` table
                    string query = "SELECT role FROM login WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString(); // Fetch role from database

                        MessageBox.Show("Login Successful! Redirecting to " + role + " dashboard.");

                       
                        /*if (role == "Admin")
                        {
                            this.Hide();
                            AdminDashboard adminForm = new AdminDashboard();
                            adminForm.Show();
                        }
                        else if (role == "Accountant")
                        {
                            this.Hide();
                            AccountantDashboard accountantForm = new AccountantDashboard();
                            accountantForm.Show();
                        }
                        else if (role == "Teacher")
                        {
                            this.Hide();
                            TeacherDashboard teacherForm = new TeacherDashboard();
                            teacherForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unknown role detected.");
                        }*/
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }
    }
}


