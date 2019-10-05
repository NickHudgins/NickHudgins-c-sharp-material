using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        [TestMethod]
        public void less20Test()
        {
            //less20(18) → true
            //less20(19) → true
            //less20(20) → false

            Less20 testClass = new Less20();

            bool result = testClass.IsLessThanMultipleOf20(18);
            Assert.IsTrue(result);

            result = testClass.IsLessThanMultipleOf20(19);
            Assert.IsTrue(result);

            result = testClass.IsLessThanMultipleOf20(20);
            Assert.IsFalse(result);
        }
    }
}
