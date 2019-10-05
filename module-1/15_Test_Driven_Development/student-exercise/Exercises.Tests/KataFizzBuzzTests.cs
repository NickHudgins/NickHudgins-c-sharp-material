using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        public void FizzBuzzTest(int i, string expectedString)
        {
            KataFizzBuzz testClass = new KataFizzBuzz();
            string result = testClass.FizzBuzz(i);
            Assert.AreEqual(expectedString, result);
        }
    }
}
