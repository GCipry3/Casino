/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality:  
 * This ProxyUser class implements the IUser interface and provides a proxy to control access to the IUser.
 * It supports additional functionalities such as password encryption and validation.
 */

using System.Linq;

namespace Users
{
    public class ProxyUser : IUser
    {
        private IUser user;

        // Accessor and mutator for Username
        public string Username
        {
            get { return user.Username; }
            set { user.Username = value; }
        }

        // Accessor and mutator for Password
        public string Password
        {
            get { return user.Password; }
            set { user.Password = value; }
        }

        // Accessor and mutator for Balance
        public int Balance
        {
            get { return user.Balance; }
            set { user.Balance = value; }
        }

        // Accessor and mutator for Role
        public string Role
        {
            get { return user.Role; }
            set { user.Role = value; }
        }

        // Constructor that sets the IUser instance
        public ProxyUser(IUser user)
        {
            this.user = user;
        }

        // Default constructor
        public ProxyUser() { }

        // Method to encrypt password with simple encryption algorithm
        public string EncryptPassword(string password)
        {
            var encrypted = password.Select(c => (char)(c + 3)).ToArray();
            return new string(encrypted);
        }

        // Private method to decrypt password
        private string DecryptPassword(string password)
        {
            var decrypted = password.Select(c => (char)(c - 3)).ToArray();
            return new string(decrypted);
        }

        // Method to validate the password with the decrypted password
        public bool ValidatePassword(string password)
        {
            // Decrypt the stored password and compare it to the provided password.
            return DecryptPassword(user.Password) == password;
        }

    }

}
