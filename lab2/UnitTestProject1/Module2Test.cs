using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTestProject1
{
    [TestClass]
    public class Module2Test
    {
        [TestMethod]
        public void CheckVowels_Test1()
        {
            Assert.AreEqual(Module2.countVowels("ееббддее"), 4);
            Assert.AreEqual(Module2.countVowels("здклкртттт"), 0);
            Assert.AreEqual(Module2.countVowels(""), 0);
            
        }
        [TestMethod]
        public void CheckNotVowels_Test1()
        {
            Assert.AreEqual(Module2.countNotVowels("aa бб дд ее"), 4);
            Assert.AreEqual(Module2.countNotVowels("ее ее ее еее"), 0);
            Assert.AreEqual(Module2.countNotVowels(""), 0);
        }
    }
}
