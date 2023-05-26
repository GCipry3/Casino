using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;

namespace Database
{
    public class UserDatabase
    {
        private Database db ;
        public UserDatabase() { 
            db = new Database();
        }

        public bool CreateUser(string username, string password, string role)
        {
            SQLiteConnection conn = db.GetDBConnection();
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = $"INSERT INTO Users (Username, Password, Role) VALUES ('{username}', '{password}', '{role}');";
                var result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (SQLiteException)
            {
                return false;
            }
        }


        public bool DeleteUser(string username)
        {
            SQLiteConnection conn = db.GetDBConnection();
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = $"DELETE FROM Users WHERE Username = '{username}';";
                var result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        public User GetUser(string username)
        {
            SQLiteConnection conn = db.GetDBConnection();
            try
            {
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
            SQLiteConnection conn = db.GetDBConnection();
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
