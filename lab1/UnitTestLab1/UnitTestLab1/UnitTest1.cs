using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;

namespace UnitTestLab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Module1.doSort(""), "");
            Assert.AreEqual(Module1.doSort("32 1 4"), "1 4 32 ");
            Assert.AreEqual(Module1.doSort("32sd 1 4sd sda"), "1 4 32 ");
            Assert.AreEqual(Module1.doSort("32 1 asd"), "1 32 ");
            
        }
    }
}
