/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality:  
 *          This class, SQLiteUserDatabase, is a part of the data access layer in the software. 
 *          It implements the IUserDatabase interface, meaning it provides a concrete implementation 
 *          of how to interact with a SQLite database where user information is stored.
 *          The class holds an IDatabase object for database operations.
*/

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
        public SQLiteUserDatabase(IDatabase database)
        {
            db = database;
        }

        public IUser GetUser(string username)
        {
            DbDataReader reader = db.ExecuteUserQueryWithResult($"SELECT * FROM Users WHERE Username = '{username}';");

            // Check if the user exists in the database
            if (reader.HasRows)
            {
                reader.Read();

                // Create and return User object
                return new User
                (
                    reader.GetString(0), //username
                    reader.GetString(1), //password
                    reader.GetString(3), //role
                    reader.GetInt32(2)   //balance
                );
            }
            else
            {
                // Return null if user doesn't exist
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
            
            if( !reader.HasRows )
            {
                reader.Close();
                throw new Exception($"The user {username} does not exist in the database");
            }
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
