using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        //dateFashion(5, 10) → 2
        //dateFashion(5, 2) → 0
        //dateFashion(5, 5) → 1

        [TestMethod]
        public void dateFashioTest()
        {
            DateFashion testClass = new DateFashion();

            int result = testClass.GetATable(5, 10);
            Assert.AreEqual(result, 2);

            result = testClass.GetATable(5, 2);
            Assert.AreEqual(result, 0);

            result = testClass.GetATable(5, 5);
            Assert.AreEqual(result, 1);
        }
    }
}
