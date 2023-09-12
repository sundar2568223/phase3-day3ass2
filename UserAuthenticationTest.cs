using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    [TextFixture]
    public class UserAuthenticationTest
    {

        private UserAuthenticator userAuthenticator;

        [SetUp]
        public void Setup()
        {
            userAuthenticator = new UserAuthenticator();
        }

        [Test]
        public void TestUserRegistration()
        {
            // Test user registration
            Assert.IsTrue(userAuthenticator.RegisterUser("user1", "password1"));
            Assert.IsFalse(userAuthenticator.RegisterUser("user1", "password2")); // Duplicate registration should fail
        }

        [Test]
        public void TestUserLogin()
        {
            // Test user login
            userAuthenticator.RegisterUser("user1", "password1");
            Assert.IsTrue(userAuthenticator.LoginUser("user1", "password1"));
            Assert.IsFalse(userAuthenticator.LoginUser("user1", "wrongpassword")); // Incorrect password
            Assert.IsFalse(userAuthenticator.LoginUser("user2", "password1")); // User not registered
        }

        [Test]
        public void TestPasswordReset()
        {
            // Test password reset
            userAuthenticator.RegisterUser("user1", "password1");
            Assert.IsTrue(userAuthenticator.ResetPassword("user1", "newpassword"));
            Assert.IsFalse(userAuthenticator.ResetPassword("user2", "newpassword")); // User not registered
        }
    }
}
