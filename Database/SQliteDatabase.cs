/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: 
 * The SQliteDatabase class implements the IDatabase interface to provide SQLite database-specific operations. 
 * It provides methods for executing queries, and manages the connection to the SQLite database.
 */

using System;
using System.IO;
using System.Data.SQLite;
using System.Data.Common;

namespace Database
{
    public class SQliteDatabase : IDatabase
    {
        private string connectionString;
        private DbConnection conn;

        public SQliteDatabase()
        {
            // Get connection string and establish database connection
            connectionString = GetDBPath();
            conn = GetDBConnection();
        }

        string GetDBPath()
        {
            // Method to generate the connection string for SQLite database
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directoryInfo = new DirectoryInfo(baseDirectory);
            directoryInfo = directoryInfo.Parent.Parent.Parent;
            string databasePath = Path.Combine(directoryInfo.FullName, "Database", "Resources", "Users.db");
            return $"Data Source={databasePath}";
        }

        public DbConnection GetDBConnection()
        {
            // Establish a connection to SQLite database
            DbConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();
            }
            catch (Exception exception)
            {
                throw new Exception($"The connection with the database could not be established\nException: {exception}");
            }

            return conn;
        }

        public DbDataReader ExecuteUserQueryWithResult(string query)
        {
            // Execute a database query and return the result as a DbDataReader
            try
            {
                DbCommand command = conn.CreateCommand();
                command.CommandText = query;
                DbDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void ExecuteUserQuery(string query)
        {
            // Execute a database query without returning any result
            try
            {
                DbCommand command = conn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
    }
}
