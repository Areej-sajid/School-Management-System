using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public static class DatabaseConnection
    {
        
        private static string connectionString = "server=localhost; database=credentials; uid=root; pwd=areejsajidnaveed23;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true; // Connection successful
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Error: " + ex.Message);
                return false; // Connection failed
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}

