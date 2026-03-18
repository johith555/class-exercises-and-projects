using SecureUserManagement.Data;
using SecureUserManagement.Services;
using Xunit;
using System;

namespace SecureUserManagement.Tests
{
    public class AuthenticationTests
    {
        [Fact]
        public void Register_And_Login_Should_Succeed()
        {
            var store = new InMemoryUserStore();
            var auth = new AuthenticationService(store);

            auth.Register("testuser", "mypassword");

            bool result = auth.Authenticate("testuser", "mypassword");

            Assert.True(result);
        }

        [Fact]
        public void Login_With_Wrong_Password_Should_Fail()
        {
            var store = new InMemoryUserStore();
            var auth = new AuthenticationService(store);

            auth.Register("testuser", "mypassword");

            bool result = auth.Authenticate("testuser", "wrongpassword");

            Assert.False(result);
        }

        [Fact]
        public void Register_With_Empty_Password_Should_Throw_Exception()
        {
            var store = new InMemoryUserStore();
            var auth = new AuthenticationService(store);

            Assert.Throws<ArgumentException>(() =>
                auth.Register("user", "")
            );
        }
    }
}