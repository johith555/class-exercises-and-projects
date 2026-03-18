using System.Security.Cryptography;
using System.Text;
using SecureUserManagement.Data;
using SecureUserManagement.Models;

namespace SecureUserManagement.Services
{
    public class AuthenticationService
    {
        private readonly InMemoryUserStore _userStore;

        public AuthenticationService(InMemoryUserStore userStore)
        {
            _userStore = userStore;
        }

        public void Register(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be empty.");

            string hashedPassword = HashPassword(password);
            var user = new User(username, hashedPassword);

            _userStore.AddUser(user);
        }

        public bool Authenticate(string username, string password)
        {
            var user = _userStore.GetUser(username);

            if (user == null)
                return false;

            string hashedInput = HashPassword(password);

            return user.HashedPassword == hashedInput;
        }

        private string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}