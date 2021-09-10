using NUnit.Framework;
using System;

namespace UseTestCase.Tests
{
    [TestFixture]
    public class MyMathTest
    {
        [TestCase(0,1)]
        [TestCase(1, 1)]
        [TestCase(3, 6)]
        [TestCase(5, 120)]
        public void Factorial_Parameter(int n, int expectedResult)
        {
            Assert.AreEqual(expectedResult, MyMath.Factorial(n));
        }

        [TestCase(0, TestName = "0! == 1", ExpectedResult = 1)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(5, ExpectedResult = 120)]
        public int Factorial_Parameter2(int n)
        {
            return MyMath.Factorial(n);
        }

        /*[Test]
        public void Factorial_Zero()
        {
            Assert.AreEqual(1, MyMath.Factorial(0));
        }

        [Test]
        public void Factorial_One()
        {
            Assert.AreEqual(1, MyMath.Factorial(1));
        }

        [Test]
        public void Factorial_Three()
        {
            Assert.AreEqual(6, MyMath.Factorial(3));
        }

        [Test]
        public void Factorial_Five()
        {
            Assert.AreEqual(120, MyMath.Factorial(5));
        }*/
    }
}
