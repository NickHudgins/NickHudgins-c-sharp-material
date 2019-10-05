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
        [DataTestMethod]
        [DataRow(1, "1")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(22, "22")]
        [DataRow(0, "")] //worked with Hala and Tom, was told to reference the student book! 

        public void FizzBuzzTest(int i, string enteredString) 
        {
            KataFizzBuzz testClass = new KataFizzBuzz();
            string result = testClass.FizzBuzz(i);
            Assert.AreEqual(enteredString, result);
        }


    }
}
