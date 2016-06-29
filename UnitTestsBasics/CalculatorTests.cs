using System;
using NUnit.Framework;

namespace UnitTestsBasics
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
        }

        [Test]
        public void MultiplyShouldReturnCorrectMultiplicationResult()
        {
            var result = calculator.Multiply(5, 5);

            Assert.AreEqual(25, result);
        }

        [Test]
        public void MultiplyShouldSupportResultThatIsHigherThanIntMax()
        {
            var result = calculator.Multiply(int.MaxValue, 2);

            Assert.AreEqual(4294967294, result);
        }

        [Test]
        public void DivideShouldThrowIfSecondNumberZero()
        {
            Assert.Throws(typeof(DivideByZeroException), () => calculator.Divide(5, 0));
        }

        [Test]
        public void DivideShouldReturnCorrectDivisionResult()
        {
            var result = calculator.Divide(10, 2);

            Assert.AreEqual(5, result);
        }
    }
}