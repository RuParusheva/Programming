using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01.HelloWorld.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = HelloWorld.GetGreeting("Gosho");
            var expected = "Hello, Gosho!";

            Assert.AreEqual(expected, actual, "GetGreeting failed!");
        }
    }
}
