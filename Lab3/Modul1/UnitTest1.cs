using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
namespace Modul1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            // Проверка количества чисел
            Assert.AreEqual(Form1.Module1.CheckCountDigit("1004"),true);
            Assert.AreEqual(Form1.Module1.CheckCountDigit("100"), false);
            // Проверка позитивных чисел
           Assert.AreEqual(Form1.Module1.PositiveDigits("3423 3423 4353"), true);
           Assert.AreEqual(Form1.Module1.PositiveDigits("3423 3423 -4353"), false);
            // Проверка 7 - как самая большое число
            Assert.AreEqual(Form1.Module2.CheckSeven("1007"),true);
            Assert.AreEqual(Form1.Module2.CheckSeven("1078"), false);
            // Проверка средне арифмитическое меньше 7
            Assert.AreEqual(Form1.Module2.CheckSevenAverage("1007"), true);
            Assert.AreEqual(Form1.Module2.CheckSevenAverage("9999"), false);
            // Проверка всех значений в списке
            Assert.AreEqual(Form1.Module2.NumberWithOptions("1007 2007 1001"), " 1007 2007");
            Assert.AreEqual(Form1.Module2.NumberWithOptions("1001 2001 1001"), "");
        }
    }
}
