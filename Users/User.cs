using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; } 
        public int Balance { get; set; }
        public string Role { get; set; }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Balance = 0;
            Role = role;
        }
        public User(string username, string password, string role, int balance)
        {
            Username = username;
            Password = password;
            Role = role;
            Balance = balance;
        }

    }
}
