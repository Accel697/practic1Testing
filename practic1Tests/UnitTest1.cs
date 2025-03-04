using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using practic1;

namespace practic1Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Factorial_Test()
        {
            Assert.AreEqual(1, Program.Factorial(0));
            Assert.AreEqual(120, Program.Factorial(5));
        }

        [TestMethod]
        public void Reverse_Test()
        {
            Assert.AreEqual("world hello", Program.Reverse("hello world"));
            Assert.AreEqual("sleep is the best rest", Program.Reverse("rest best the is sleep")); 
        }

        [TestMethod]
        public void MaxLength_Test()
        {
            Assert.AreEqual(1, Program.MaxLength("3 2 7"));
            Assert.AreEqual(4, Program.MaxLength("1 2 4 8 8 16 32")); 
        }

        [TestMethod]
        public void CompareWordStrength_Test()
        {
            Assert.IsFalse(Program.CompareWordStrength("б", "в"));
            Assert.IsTrue(Program.CompareWordStrength("аг", "бв")); 
        }

        [TestMethod]
        public void GCD_Test()
        {
            Assert.AreEqual(6, Program.GCD(54, 24));
            Assert.AreEqual(4, Program.GCD(-8, 12));
        }
    }
}
