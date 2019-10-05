using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        //* GetHerd("giraffe") → "Tower"
        // * GetHerd("") -> "unknown"         
        //* GetHerd("walrus") -> "unknown"
        //* GetHerd("Rhino") -> "Crash"
        // * GetHerd("rhino") -> "Crash"
        //* GetHerd("elephants") -> "unknown"

        [TestMethod]
        public void GetHeardTest()
        {
            AnimalGroupName testClass = new AnimalGroupName();


            string result = testClass.GetHerd("");
            Assert.AreEqual("unknown", result);

            result = testClass.GetHerd("giraffe");
            Assert.AreEqual("Tower", result);

            result = testClass.GetHerd("walrus");
            Assert.AreEqual("unknown", result);

            result = testClass.GetHerd("Rhino");
            Assert.AreEqual("Crash", result);

            result = testClass.GetHerd("rhino");
            Assert.AreEqual("Crash", result);

            result = testClass.GetHerd("elephants");
            Assert.AreEqual("unknown", result);
        }


    }
}
