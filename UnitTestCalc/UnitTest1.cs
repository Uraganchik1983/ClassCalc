using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sum_10_20_rez_30()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            ClassCalc.Class1 class2 = new ClassCalc.Class1();
            int actual = class2.Summ(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
