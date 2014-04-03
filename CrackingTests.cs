using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PWCrackService;

namespace PasswordCrackingSlaveUnitTest
{
    [TestClass]
    public class CrackingTests
    {
        //[TestMethod]
        public void TestRunCracking()
        {
            Cracking cracker = new Cracking();
            var words = ReadFile("webster-dictionary.txt");
            UserInfo info = new UserInfo("Nicolai", "EQ91A67FOpjss4uW8kV570lnSa0=");
            List<UserInfo> list = new List<UserInfo>();
            List<string> wordlist = words.ToList();

            list.Add(info);
            var result = cracker.RunCracking(wordlist, list);
            string crack = string.Join(", ", result);
            Assert.AreEqual(crack, "Nicolai: BOAT");



        }
        public static string[] ReadFile(String filename)
        {
            var fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            using (var sr = new StreamReader(fs))
            {
                return sr.ReadToEnd().Split('\n');
            }
        }

    }
}
