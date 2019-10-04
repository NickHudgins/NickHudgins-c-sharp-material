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


            string result = testClass.GetHerd("rhino");
            Assert.AreEqual("Crash", result);

            result = testClass.GetHerd("giraffe");
            Assert.AreEqual("Tower", result);

            result = testClass.GetHerd("elephant");
            Assert.AreEqual("Herd", result);

            result = testClass.GetHerd("lion");
            Assert.AreEqual("Pride", result);

            result = testClass.GetHerd("crow");
            Assert.AreEqual("Murder", result);

            result = testClass.GetHerd("pigeon");
            Assert.AreEqual("Kit", result);

            result = testClass.GetHerd("flamingo");
            Assert.AreEqual("Pat", result);

            result = testClass.GetHerd("deer");
            Assert.AreEqual("Heard", result);

            result = testClass.GetHerd("dog");
            Assert.AreEqual("Pack", result);

            result = testClass.GetHerd("Crocodile");
            Assert.AreEqual("Float", result);

        }


    }
}
