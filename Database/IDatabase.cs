using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IDatabase
    {
        DbConnection GetDBConnection();
        DbDataReader ExecuteUserQueryWithResult(string query);
        void ExecuteUserQuery(string query);

    }
}
