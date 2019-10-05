using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void wordCountTest()
        {
            //GetCount(["ba", "ba", "black", "sheep"]) → { "ba" : 2, "black": 1, "sheep": 1 }
            //GetCount(["a", "b", "a", "c", "b"]) → { "b": 2, "c": 1, "a": 2}
            //GetCount([]) → { }
            //GetCount(["c", "b", "a"]) → { "b": 1, "c": 1, "a": 1}

            WordCount testClass = new WordCount();

            string[] result = { "ba", "ba", "black", "sheep" };
            Dictionary<string, int> testDictionary = testClass.GetCount(result);
            Dictionary<string, int> input = new Dictionary<string, int>
            {
              { "ba", 2}, {"black", 1 }, {"sheep", 1}

            };
            CollectionAssert.AreEqual(testDictionary, input);


        }
    }
}
