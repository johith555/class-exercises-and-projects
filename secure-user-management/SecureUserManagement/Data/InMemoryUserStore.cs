using SecureUserManagement.Models;

namespace SecureUserManagement.Data
{
    public class InMemoryUserStore
    {
        private readonly Dictionary<string, User> _users = new();

        public void AddUser(User user)
        {
            if (_users.ContainsKey(user.Username))
                throw new InvalidOperationException("User already exists.");

            _users[user.Username] = user;
        }

        public User? GetUser(string username)
        {
            _users.TryGetValue(username, out var user);
            return user;
        }
    }
}