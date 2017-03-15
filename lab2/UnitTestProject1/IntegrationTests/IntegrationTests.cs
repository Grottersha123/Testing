using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTestProject1.IntegrationTests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void Integration_Vowels_Test1()
        {
            String s = "я вижу теб я когда т ы";
            Assert.AreEqual(Module1.checkStrLength(s), true);
            Assert.AreEqual(Module1.isOddWordsMore(s), true);
            Assert.AreEqual(Module2.countVowels(s), 8);
        }
        public void Integration_Vowels_Test2()
        {
            String s = "няш няш няш няш ты ты ты ты";
            Assert.AreEqual(Module1.checkStrLength(s), true);
            Assert.AreEqual(Module1.isOddWordsMore(s), true);
            Assert.AreEqual(Module2.countVowels(s), 8);
        }

        [TestMethod]
        public void Integration_NotVowels_Test1()
        {
            String s = "ддды ддаа дуду а";
            Assert.AreEqual(Module1.checkStrLength(s), true);
            Assert.AreEqual(Module1.isOddWordsMore(s), false);
            Assert.AreEqual(Module2.countNotVowels(s), 7);
        }
        [TestMethod]
        public void Integration_NotVowels_Test2()
        {
            String s = "Привет мой маленький пирожок";
            Assert.AreEqual(Module1.checkStrLength(s), true);
            Assert.AreEqual(Module1.isOddWordsMore(s), false);
            Assert.AreEqual(Module2.countNotVowels(s), 15);
        }
    }
}
