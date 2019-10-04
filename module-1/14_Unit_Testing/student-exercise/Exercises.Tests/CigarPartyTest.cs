﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        //haveParty(30, false) → false
        //haveParty(50, false) → true
        //haveParty(70, true) → true


        [TestMethod]
        public void havePartyTest()
        {
            CigarParty testClass = new CigarParty();

            bool result = testClass.HaveParty(30, false);
            Assert.IsFalse(false);

            result = testClass.HaveParty(50, false);
            Assert.IsFalse(true);

            result = testClass.HaveParty(70, true);
            Assert.IsFalse(true);
        }
    }
}