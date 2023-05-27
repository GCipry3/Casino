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
        private SQLiteConnection conn;
        public UserDatabase() { 
            Database db = new Database();
            conn = db.GetDBConnection();
        }

        public bool CreateUser(string username, string password, string role)
        {
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


        public SQLiteDataReader ExecuteUserQueryWithResult(string query)
        {
            try
            {
                var command = conn.CreateCommand();

                command.CommandText = query;
                var reader = command.ExecuteReader();
                return reader;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }

        void ExecuteUserQuery(string query)
        {
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            catch
            {
                conn.Close();
            }
        }
        public User GetUser(string username)
        {
            var reader = ExecuteUserQueryWithResult($"SELECT * FROM Users WHERE Username = {username};");

            try
            {
                reader.Read();
                return new User
                (
                    reader.GetString(0), //username
                    reader.GetString(1), //password
                    reader.GetString(3), //role
                    reader.GetInt32(2)   //balance
                );
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void DeleteUser(string username)
        {
            ExecuteUserQuery($"DELETE FROM Users WHERE Username = '{username}';");
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

        public int GetUserBalance(string username)
        {
            var reader = ExecuteUserQueryWithResult($"SELECT Balance FROM Users WHERE Username = '{username}';");
            reader.Read();
            int balance = reader.GetInt32(0);

            reader.Close();
            return balance;
        }

        public void AddUserBalance(string username, int amount)
        {
            int balance = GetUserBalance(username);
            balance += amount;
            UpdateUserBalance(username, balance);
        }
    }
}
