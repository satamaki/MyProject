using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gitTest1;

namespace Test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 1;
            double actual = MyPower.power(5, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double expected = 4;
            double actual = MyPower.power(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double expected = 27;
            double actual = MyPower.power(3, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double expected = 4;
            double actual = MyPower.power(-2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            double expected = -8;
            double actual = MyPower.power(-2, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
