using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Classes;

namespace TDD.Tests.Classes
{
    [TestClass]
    public class KataRomanNumeralTests
    {
        KataRomanNumeral testClass;

        [TestInitialize]
        public void Initialize()
        {
            testClass = new KataRomanNumeral();
        }



        [TestMethod]
        public void test_M_for_thousand()
        {
            KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConvertToRomanNumeral(1000);
            Assert.AreEqual("M", result);

            result = testClass.ConvertToRomanNumeral(2000);
            Assert.AreEqual("MM", result);

            result = testClass.ConvertToRomanNumeral(3000);
            Assert.AreEqual("MMM", result);

            result = testClass.ConvertToRomanNumeral(4000);
            Assert.AreEqual("MMMM", result);

            result = testClass.ConvertToRomanNumeral(5000);
            Assert.AreEqual("MMMMMM", result);
        }
        [TestMethod]
        public void Test_D_for_five_hundred()
        {
            KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConvertToRomanNumeral(500);
            Assert.AreEqual("D", result);

            result = testClass.ConvertToRomanNumeral(1500);
            Assert.AreEqual("MD", result);

            result = testClass.ConvertToRomanNumeral(2500);
            Assert.AreEqual("MMD", result);
        }

        [TestMethod]
        public void Test_C_for_hundred()
        {
            KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConvertToRomanNumeral(100);
            Assert.AreEqual("C", result);

            result = testClass.ConvertToRomanNumeral(200);
            Assert.AreEqual("CC", result);

            result = testClass.ConvertToRomanNumeral(1200);
            Assert.AreEqual("MCC", result);
        }

        [TestMethod]
        public void Test_L_for_fifty()
        {
            KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConvertToRomanNumeral(50);
            Assert.AreEqual("L", result);

            result = testClass.ConvertToRomanNumeral(150);
            Assert.AreEqual("CL", result);

            result = testClass.ConvertToRomanNumeral(1050);
            Assert.AreEqual("ML", result);

            result = testClass.ConvertToRomanNumeral(1150);
            Assert.AreEqual("MCL", result);
        }

        [TestMethod]
        public void Test_X_for_ten()
        {
            KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConvertToRomanNumeral(10);
            Assert.AreEqual("X", result);

            result = testClass.ConvertToRomanNumeral(20);
            Assert.AreEqual("XX", result);

            result = testClass.ConvertToRomanNumeral(120);
            Assert.AreEqual("CXX", result);

            result = testClass.ConvertToRomanNumeral(1020);
            Assert.AreEqual("MXX", result);
        }

        [TestMethod]
        public void Test_V_for_five()
        {
            KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConvertToRomanNumeral(5);
            Assert.AreEqual("V", result);

            result = testClass.ConvertToRomanNumeral(15);
            Assert.AreEqual("XV", result);

            result = testClass.ConvertToRomanNumeral(105);
            Assert.AreEqual("CV", result);
        }

        [TestMethod]
        public void Test_I_for_one()
        {
            KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConvertToRomanNumeral(1);
            Assert.AreEqual("I", result);

            result = testClass.ConvertToRomanNumeral(2);
            Assert.AreEqual("II", result);

            result = testClass.ConvertToRomanNumeral(3);
            Assert.AreEqual("III", result);

            result = testClass.ConvertToRomanNumeral(6);
            Assert.AreEqual("VI", result);
        }

        [TestMethod]
        public void ContractedForms()
        {
            string result = testClass.ConvertToRomanNumeral(4);
            Assert.AreEqual("IV", result);

            result = testClass.ConvertToRomanNumeral(400);
            Assert.AreEqual("CD", result);
        }
    }
}
