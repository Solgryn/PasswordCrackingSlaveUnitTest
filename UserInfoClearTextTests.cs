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
                new UserInfoText(null, null);
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                new UserInfoText(null, "test");
                Assert.Fail();
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(ex.ParamName, "username");
            }

            try
            {
                new UserInfoText("test", null);
                Assert.Fail();
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(ex.ParamName, "password");
            }

            new UserInfoText("test", "test");
            //Does not throw exception if strings are empty, but does if value is null
            new UserInfoText("", "");

        }

        [TestMethod]
        public void TestToString()
        {
            var uic = new UserInfoText("Anders", "anders123");
            Assert.AreEqual(uic.ToString(), "Anders: anders123");
            Assert.AreNotEqual(uic.ToString(), "Anders:anders123");
        }
    }
}
