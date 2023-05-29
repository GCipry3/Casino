/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: 
 * The IUserDatabase interface provides methods for managing User data in the database, 
 * encapsulating database-specific commands for user management.
 */

using Users;

namespace Database
{
    public interface IUserDatabase
    {
        // Retrieves a User based on username from the database
        IUser GetUser(string username);

        // Creates a new User in the database
        void CreateUser(string username, string password, string role);

        // Deletes a User by username from the database
        void DeleteUser(string username);

        // Updates a User's password in the database
        void UpdateUserPassword(string username, string password);

        // Updates a User's role in the database
        void UpdateUserRole(string username, string role);

        // Updates a User's balance in the database
        void UpdateUserBalance(string username, int balance);

        // Retrieves a User's balance from the database
        int GetUserBalance(string username);

        // Increases a User's balance in the database
        void AddUserBalance(string username, int amount);
    }
}
