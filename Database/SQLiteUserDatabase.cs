using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;

namespace Database
{
    public class SQLiteUserDatabase : IUserDatabase
    {
        IDatabase db;
        public SQLiteUserDatabase() { 
            db = new SQliteDatabase();
        }

        public IUser GetUser(string username)
        {
            DbDataReader reader = db.ExecuteUserQueryWithResult($"SELECT * FROM Users WHERE Username = '{username}';");
            
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
        public void CreateUser(string username, string password, string role)
        {
            db.ExecuteUserQuery($"INSERT INTO Users (Username, Password, Role) VALUES ('{username}', '{password}', '{role}');");
        }

        public void DeleteUser(string username)
        {
            db.ExecuteUserQuery($"DELETE FROM Users WHERE Username = '{username}';");
        }
        public void UpdateUserPassword(string username, string password)
        {
            db.ExecuteUserQuery($"UPDATE Users SET Password = '{password}' WHERE Username = '{username}';");
        }

        public void UpdateUserRole(string username, string role)
        {
            db.ExecuteUserQuery($"UPDATE Users SET Role = '{role}' WHERE Username = '{username}';");
        }

        public void UpdateUserBalance(string username, int balance)
        {
            db.ExecuteUserQuery($"UPDATE Users SET Balance = '{balance}' WHERE Username = '{username}';");
        }

        public int GetUserBalance(string username)
        {
            DbDataReader reader = db.ExecuteUserQueryWithResult($"SELECT Balance FROM Users WHERE Username = '{username}';");
            
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
