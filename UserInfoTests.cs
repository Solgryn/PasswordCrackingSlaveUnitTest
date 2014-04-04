using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PWCrackService;

namespace PasswordCrackingSlaveUnitTest
{
    [TestClass]
    public class UserInfoTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            try
            {
                new UserInfo(null, null);
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {

            }

            try
            {
                new UserInfo(null, "test");
                Assert.Fail();
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(ex.ParamName, "username");
            }

            try
            {
                new UserInfo("test", null);
                Assert.Fail();
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(ex.ParamName, "entryptedPasswordBase64");
            }

            new UserInfo("test", "test");
            //Does not throw exception if strings are empty, but does if value is null
            new UserInfo("", "");

        }

        [TestMethod]
        public void TestToString()
        {
            var uic = new UserInfo("Anders", "5en6G6MezRroT3XKqkdPOmY/BfQ=");
            Assert.AreEqual(uic.ToString(), "Anders: 5en6G6MezRroT3XKqkdPOmY/BfQ=");
        }
    }
}
