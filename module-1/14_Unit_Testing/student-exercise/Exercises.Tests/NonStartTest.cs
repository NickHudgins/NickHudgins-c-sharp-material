using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void nonStartTest()
        {
            //GetPartialString("Hello", "There") → "ellohere"
            //GetPartialString("java", "code") → "avaode"
            //GetPartialString("shotl", "java") → "hotlava"

            NonStart testClass = new NonStart();

            string result = testClass.GetPartialString("Hello", "There");
            Assert.AreEqual("ellohere", result);

            result = testClass.GetPartialString("java", "code");
            Assert.AreEqual("avaode", result);

            result = testClass.GetPartialString("shotl", "java");
            Assert.AreEqual("hotlava", result);
        }
    }
}
