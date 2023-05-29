﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
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
            connectionString = GetDBPath();
            conn = GetDBConnection();
        }
        string GetDBPath()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directoryInfo = new DirectoryInfo(baseDirectory);

            // Go up 3 directories from the baseDirectory
            directoryInfo = directoryInfo.Parent.Parent.Parent;

            string databasePath = Path.Combine(directoryInfo.FullName, "Database", "Resources", "Users.db");
            return $"Data Source={databasePath}";
        }

        public DbConnection GetDBConnection()
        {
            DbConnection conn = new SQLiteConnection(connectionString);

            for(int i = 0; i < 3; i++)
            {
                try
                {
                    conn.Open();
                    break;
                }
                catch (Exception)
                {
                }
            }

            return conn;
        }

        public DbDataReader ExecuteUserQueryWithResult(string query)
        {
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
