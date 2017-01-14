using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDelta()
        {
            Testy.Program.a = 2;
            Testy.Program.b = 4;
            Testy.Program.c = 2;

            double result = Testy.Program.CalculateDelta();
            double expResult = 0;

            Assert.AreEqual(result, expResult);
        }
    }
}