using SecureUserManagement.Services;
using Xunit;

namespace SecureUserManagement.Tests
{
    public class EncryptionTests
    {
        [Fact]
        public void Encryption_And_Decryption_Should_Work()
        {
            var encryption = new EncryptionService();

            string original = "SensitiveData";

            string encrypted = encryption.Encrypt(original);
            string decrypted = encryption.Decrypt(encrypted);

            Assert.Equal(original, decrypted);
        }
    }
}