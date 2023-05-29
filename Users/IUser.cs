/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality:  
 * This interface, IUser, defines the blueprint for a User object within the application. It declares the necessary properties 
 * a user must have, providing flexibility for different implementations of a User.
 */

namespace Users
{
    public interface IUser
    {
        // The username of the user
        string Username { get; set; }

        // The password of the user
        string Password { get; set; }

        // The balance of the user
        int Balance { get; set; }

        // The role of the user in the application (eg: admin, user etc.)
        string Role { get; set; }
    }
}
