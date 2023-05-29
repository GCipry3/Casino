/*
 * Created by: Galbeaza Ciprian
 *
 * Functionality:
 * The IDatabase interface provides an abstraction for a database connection and
 * common database operations, promoting code reusability and interchangeability.
 */

using System.Data.Common;

namespace Database
{
    public interface IDatabase
    {
        // Establishes and returns a connection to the database.
        DbConnection GetDBConnection();

        // Executes a SELECT query on the database and returns the resulting data.
        DbDataReader ExecuteUserQueryWithResult(string query);

        // Executes an INSERT, UPDATE, or DELETE query on the database.
        void ExecuteUserQuery(string query);
    }
}
