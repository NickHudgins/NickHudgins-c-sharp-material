using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        //frontTimes("Chocolate", 2) → "ChoCho"
        //frontTimes("Chocolate", 3) → "ChoChoCho"
        //frontTimes("Abc", 3) → "AbcAbcAbc"

        [TestMethod]
        public void frontTimesTest()
        {

            FrontTimes testClass = new FrontTimes();

            string result = testClass.GenerateString("Chocolate", 2);
            Assert.AreEqual(result, "ChoCho");

            result = testClass.GenerateString("Chocolate", 3);
            Assert.AreEqual(result, "ChoChoCho");

            result = testClass.GenerateString("Abc", 3);
            Assert.AreEqual(result, "AbcAbcAbc");
        }
    }
}