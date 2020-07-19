﻿using AngouriMath;
using AngouriMath.Core.Numerix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class Sys
    {
        [TestMethod]
        public void NumberTest1()
        {
            ComplexNumber a = 3;
            ComplexNumber b = MathS.i;
            ComplexNumber c = a + b;
            Assert.AreEqual(ComplexNumber.Create(3, 1), c);
        }

        [TestMethod]
        public void TestNumber1()
            => Assert.IsFalse(ComplexNumber.TryParse("quack", out _));

        [TestMethod]
        public void TestNumber2()
            => Assert.IsFalse(ComplexNumber.TryParse("i1", out _));

        [TestMethod]
        public void TestNumber3()
            => Assert.IsFalse(ComplexNumber.TryParse("ii", out _));

        [TestMethod]
        public void TestNumber4()
            => Assert.IsFalse(ComplexNumber.TryParse("", out _));

        [TestMethod]
        public void TestNumber5()
            => Assert.IsTrue(ComplexNumber.TryParse("233i", out _));

        [TestMethod]
        public void TestNumber6()
            => Assert.IsTrue(ComplexNumber.TryParse("-4i", out _));

        [TestMethod]
        public void TestNumber7()
            => Assert.IsTrue(ComplexNumber.TryParse("-i", out _));

        public void TestNumber8()
            => Assert.IsTrue(ComplexNumber.TryParse("-5.3i", out _));

        public void TestNumber9()
            => Assert.IsTrue(ComplexNumber.TryParse("5.3", out _));
    }
}
