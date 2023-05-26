using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using System.Data.SQLite;


namespace Database
{
    public class Database
    {
        private static Database instance = null;
        string connectionString;

        private Database()
        {
            connectionString = GetDBPath();
        }
        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }

            return instance;
        }
        public string GetDBPath()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directoryInfo = new DirectoryInfo(baseDirectory);

            // Go up 3 directories from the baseDirectory
            for (int i = 0; i < 3; i++)
            {
                directoryInfo = directoryInfo.Parent;
                if (directoryInfo == null)
                {
                    throw new Exception("Invalid base directory: not enough parent directories");
                }
            }

            string databasePath = Path.Combine(directoryInfo.FullName, "Database", "Resources", "Users.db");
            return $"Data Source={databasePath}";
        }

        SQLiteConnection GetDBConnection()
        {
            SQLiteConnection conn = null;
            conn = new SQLiteConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch { }

            return conn;
        }


        public bool CreateUser(string username, string password, string role)
        {
            SQLiteConnection conn = GetDBConnection();
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = $"INSERT INTO Users (Username, Password, Role) VALUES ('{username}', '{password}', '{role}');";
                var result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch(SQLiteException) { 
                return false;
            }
        }


        public bool DeleteUser(string username)
        {
            SQLiteConnection conn = GetDBConnection();
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = $"DELETE FROM Users WHERE Username = '{username}';";
                var result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (SQLiteException) {
                return false;
            }
        }

        public User GetUser(string username)
        {
            SQLiteConnection conn = GetDBConnection();
            try { 
                var command = conn.CreateCommand();

                // Prevent SQL injection
                command.CommandText = $"SELECT * FROM Users WHERE Username = @username;";
                command.Parameters.AddWithValue("@username", username);
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    return new User
                    (
                        reader.GetString(0), //username
                        reader.GetString(1), //password
                        reader.GetString(3), //role
                        reader.GetInt32(2)  //balance
                    );
                }
            }
            catch { return null; }
        }

        void ExecuteUserQuery(string query)
        {
            SQLiteConnection conn = GetDBConnection();
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            catch { }
        }

        public void UpdateUserPassword(string username, string password)
        {
            ExecuteUserQuery($"UPDATE Users SET Password = '{password}' WHERE Username = '{username}';");
        }

        public void UpdateUserRole(string username, string role)
        {
            ExecuteUserQuery($"UPDATE Users SET Role = '{role}' WHERE Username = '{username}';");
        }

        public void UpdateUserBalance(string username, int balance)
        {
            ExecuteUserQuery($"UPDATE Users SET Balance = '{balance}' WHERE Username = '{username}';");
        }
    }
}
