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
    internal class Database
    {
        private string connectionString;

        public Database()
        {
            connectionString = GetDBPath();
        }
        string GetDBPath()
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

        public SQLiteConnection GetDBConnection()
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


    }
}
