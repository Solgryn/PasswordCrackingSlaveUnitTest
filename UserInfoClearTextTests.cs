using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PWCrackService;

namespace PasswordCrackingSlaveUnitTest
{
    [TestClass]
    public class UserInfoTextTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            try
            {
                new UserInfoClearText(null, null);
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                new UserInfoClearText(null, "test");
                Assert.Fail();
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(ex.ParamName, "username");
            }

            try
            {
                new UserInfoClearText("test", null);
                Assert.Fail();
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(ex.ParamName, "password");
            }

            new UserInfoClearText("test", "test");
            //Does not throw exception if strings are empty, but does if value is null
            new UserInfoClearText("", "");

        }

        [TestMethod]
        public void TestToString()
        {
            var uic = new UserInfoClearText("Anders", "anders123");
            Assert.AreEqual(uic.ToString(), "Anders: anders123");
        }
    }
}
