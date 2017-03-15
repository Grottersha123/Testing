using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTestProject1
{
    [TestClass]
    public class Module1Test
    {
        [TestMethod]
        public void CheckLenght_Test1()
        {
            Assert.AreEqual(Module1.checkStrLength("при при при при при при при при при"), false); // больше 30
            Assert.AreEqual(Module1.checkStrLength("you are my really good friend you know it"), false); // больше 30
            Assert.AreEqual(Module1.checkStrLength("ааа ааа ааа"), true); // меньше 30
            Assert.AreEqual(Module1.checkStrLength("Hello world"), true); // меньше 30


        }
        [TestMethod]
        public void CheckCountOfOddWords_Test2()
        {
            Assert.AreEqual(Module1.isOddWordsMore("я вижу теб я когда т ы"), true); // больше 3
            Assert.AreEqual(Module1.isOddWordsMore("Даа дааа дааа аа"), false); // меньше 3
            Assert.AreEqual(Module1.isOddWordsMore("чем чем чем чем"), true); // больше 3
            Assert.AreEqual(Module1.isOddWordsMore("меньше чем ты только я"), false);// меньше 3
        }
    }
    
   
}
