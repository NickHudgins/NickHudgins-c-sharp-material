using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void lucky13Test()
        {
            //GetLucky([0, 2, 4]) → true
            //GetLucky([1, 2, 3]) → false
            //GetLucky([1, 2, 4]) → false

            Lucky13 testClass = new Lucky13();

            bool result = testClass.GetLucky(new int[] { 0, 2, 4});
            Assert.IsTrue(result);

            result = testClass.GetLucky(new int[] { 1, 2, 3 });
            Assert.IsFalse(result);

            result = testClass.GetLucky(new int[] { 1, 2, 4 });
            Assert.IsFalse(result);
        }
    }
}
