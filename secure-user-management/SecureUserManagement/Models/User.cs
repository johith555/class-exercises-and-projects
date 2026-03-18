namespace SecureUserManagement.Models
{
    public class User
    {
        public string Username { get; private set; }
        public string HashedPassword { get; private set; }

        public User(string username, string hashedPassword)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be empty.");

            if (string.IsNullOrWhiteSpace(hashedPassword))
                throw new ArgumentException("Password hash cannot be empty.");

            Username = username;
            HashedPassword = hashedPassword;
        }
    }
}