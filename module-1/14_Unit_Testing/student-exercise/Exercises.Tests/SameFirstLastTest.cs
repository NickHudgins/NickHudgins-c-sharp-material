using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void sameFirstLastTest()
        {
            //IsItTheSame([1, 2, 3]) → false
            //IsItTheSame([1, 2, 3, 1]) → true
            //IsItTheSame([1, 2, 1]) → true

            SameFirstLast testClass = new SameFirstLast();

            bool result = testClass.IsItTheSame(new int[] { 1, 2, 3 });
            Assert.IsFalse(result);

            result = testClass.IsItTheSame(new int[] { 1, 2, 3, 1});
            Assert.IsTrue(result);

            result = testClass.IsItTheSame(new int[] { 1, 2, 1 });
            Assert.IsTrue(result);
        }
    }
}
