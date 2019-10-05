using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEndTest
    {
        [TestMethod]
        public void maxEndTest()
        {
            //MakeArray([1, 2, 3]) → [3, 3, 3]
            //MakeArray([11, 5, 9]) → [11, 11, 11]
            //MakeArray([2, 11, 3]) → [3, 3, 3]

            MaxEnd3 testClass = new MaxEnd3();

            int[] result = testClass.MakeArray(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result);

            result = testClass.MakeArray(new int[] { 11, 5, 9 });
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, result);

            result = testClass.MakeArray(new int[] { 2, 11, 3 });
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, result);
        }
    }
}
