using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void stringBitsTest()
        {
            //GetBits("Hello") → "Hlo"
            //GetBits("Hi") → "H"
            //GetBits("Heeololeo") → "Hello"

            StringBits testClass = new StringBits();

            string result = testClass.GetBits("Hello");
            Assert.AreEqual("Hlo", result);

            result = testClass.GetBits("Hi");
            Assert.AreEqual("H", result);

            result = testClass.GetBits("Heeololeo");
            Assert.AreEqual("Hello", result);










        }
    }
}
