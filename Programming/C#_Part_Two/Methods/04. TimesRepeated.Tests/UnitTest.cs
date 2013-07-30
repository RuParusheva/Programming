using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.TimesRepeated.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] myArray = { 1, 15, 17, 18, 999, 1, 233, 1, 18, 89, 1, 18, 999, 44, 18, 67, 44, 233, 1, 18 };
            int element = 15;

            int expected = 1;
            int actual = TimesRepeatedClass.DistinctCount(myArray, element);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] myArray = { 1, 15, 17, 18, 999, 1, 233, 1, 18, 89, 1, 18, 999, 44, 18, 67, 44, 233, 1, 18 };
            int element = -1;

            int expected = 0;
            int actual = TimesRepeatedClass.DistinctCount(myArray, element);

            Assert.AreEqual(expected, actual);
        }
    }
}
