using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsDemo;
namespace JenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Jenkins",Program.createMessage());
        }
    }
}
