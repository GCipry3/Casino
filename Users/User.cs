/*
 * Created by: Galbeaza Ciprian
 *
 * Functionality:
 * The User class is a simple implementation of the IUser interface, 
 * defining the basic attributes and behaviors of a User in the system.
 */

namespace Users
{
    public class User : IUser
    {
        // Properties of the User class
        public string Username { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public string Role { get; set; }

        // Constructor to initialize a new user with default balance of 0
        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Balance = 0;
            Role = role;
        }

        // Constructor to initialize a new user with a specified balance
        public User(string username, string password, string role, int balance)
        {
            Username = username;
            Password = password;
            Role = role;
            Balance = balance;
        }
    }
}
