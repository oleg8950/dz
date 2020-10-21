using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Oleg.MainClass.Series1(),169);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Oleg.MainClass.Series2(), 36288000);

        }
    }
}
