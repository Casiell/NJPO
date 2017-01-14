using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testy2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> intList = new List<int>();
            int i = 0;
            while (i <= 10000000)
            {
                Random rand = new Random();
                intList.Add(rand.Next(int.MaxValue));
                Console.WriteLine(i);
                i++;
            }
            intList.Sort();
        }
    }
}