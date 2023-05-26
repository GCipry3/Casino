using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class ProxyUser : IUser
    {
        private User user;

        public string Username
        {
            get { return user.Username; }
        }

        public string Password
        {
            get { throw new NotImplementedException("Cannot access password directly"); }
        }

        public int Balance
        {
            get { return user.Balance; }
            set { user.Balance = value; }
        }

        public string Role
        {
            get { return user.Role; }
        }

        public ProxyUser(User user)
        {
            this.user = user;
        }

        private string EncryptPassword(string password)
        {
            var encrypted = password.Select(c => (char)(c + 3)).ToArray();
            return new string(encrypted);
        }

        private string DecryptPassword(string password)
        {
            var decrypted = password.Select(c => (char)(c - 3)).ToArray();
            return new string(decrypted);
        }

        public bool ValidatePassword(string password)
        {
            // Decrypt the stored password and compare it to the provided password.
            return DecryptPassword(user.Password) == password;
        }

    }

}
