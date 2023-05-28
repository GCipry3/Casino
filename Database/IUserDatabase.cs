using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;

namespace Database
{
    public interface IUserDatabase
    {
        IUser GetUser(string username);
        void CreateUser(string username, string password, string role);
        void DeleteUser(string username);
        void UpdateUserPassword(string username, string password);
        void UpdateUserRole(string username, string role);
        void UpdateUserBalance(string username, int balance);
        int GetUserBalance(string username);
        void AddUserBalance(string username, int amount);
    }
}
