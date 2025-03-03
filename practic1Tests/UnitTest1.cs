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
            Assert.AreEqual(1, Program.Factorial(1));
            Assert.AreEqual(2, Program.Factorial(2));
            Assert.AreEqual(6, Program.Factorial(3));
            Assert.AreEqual(24, Program.Factorial(4));
            Assert.AreEqual(120, Program.Factorial(5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Program.Factorial(-1));
        }

        [TestMethod]
        public void Reverse_Test()
        {
            Assert.AreEqual("world hello", Program.Reverse("hello world"));
            Assert.AreEqual("rest best the is sleep", Program.Reverse("sleep is the best rest"));
            Assert.AreEqual("", Program.Reverse("   "));
            Assert.AreEqual("hello", Program.Reverse("hello"));
        }

        [TestMethod]
        public void MaxLength_Test()
        {
            Assert.AreEqual(5, Program.MaxLength("1 2 4 8 16"));
            Assert.AreEqual(1, Program.MaxLength("3 2 7"));
            Assert.AreEqual(0, Program.MaxLength(""));
            Assert.AreEqual(4, Program.MaxLength("1 2 4 8 8 16 32")); 
        }

        [TestMethod]
        public void CompareWordStrength_Test()
        {
            Assert.IsTrue(Program.CompareWordStrength("б", "б"));
            Assert.IsFalse(Program.CompareWordStrength("б", "в"));
            Assert.IsTrue(Program.CompareWordStrength("а", "А")); 
            Assert.IsTrue(Program.CompareWordStrength("аг", "бв")); 
        }

        [TestMethod]
        public void GCD_Test()
        {
            Assert.AreEqual(6, Program.GCD(54, 24));
            Assert.AreEqual(3, Program.GCD(9, 3));
            Assert.AreEqual(1, Program.GCD(7, 5));
            Assert.AreEqual(4, Program.GCD(-8, 12));
            Assert.AreEqual(7, Program.GCD(0, 7));
        }
    }
}
