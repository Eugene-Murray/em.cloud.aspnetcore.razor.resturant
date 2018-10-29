using Microsoft.VisualStudio.TestTools.UnitTesting;
using MurraysIrishBar.Services;

namespace MurraysIrishBar.Tests
{
    [TestClass]
    public class IdentityServiceFixture
    {
        [TestMethod]
        public void IsAdminUser_Success()
        {
            // Assign
            var identityService = new IdentityService();
            var expectedResult = true;
            var userNameEmail = "admin@murraysbar.com";
            var password = "password#";

            // Act
            var actualResult = identityService.IsAdminUser(userNameEmail, password);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsAdminUser_Fail()
        {
            // Assign
            var identityService = new IdentityService();
            var expectedResult = false;
            var userNameEmail = "adminEEEEEEE@murraysbar.com";
            var password = "password#_XXXXXccc";

            // Act
            var actualResult = identityService.IsAdminUser(userNameEmail, password);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
