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
        public void MultiplyReturnsZeroIfSecondNumberIsZero()
        {
            var result = calculator.Multiply(5, 0);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void MultiplyReturnsPositiveNumberIfBothArgumentsArePositive()
        {
            var result = calculator.Multiply(5, 5);

            Assert.AreEqual(25, result);
        }

        [Test]
        public void DivideReturnsZeroIfFirstNumberIsZero()
        {
            var result = calculator.Divide(0, 5);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void DivideByZeroShouldThrow()
        {
            try
            {
                var result = calculator.Divide(5, 0);
            }
            catch (Exception e)
            {
                if (e is DivideByZeroException)
                {
                    return;
                }
            }
            Assert.Fail("Expected DivideByZeroException");

            //Assert.Throws(typeof(DivideByZeroException), () => calculator.DivideByZeroShouldThrow(5, 0));
        }

        [Test]
        public void DivideReturnsNegativeNumberIfFirstNumberNegativeSecondPositive()
        {
            var result = calculator.Divide(-5, 2);

            Assert.AreEqual(-2.5, result);
        }

        [Test]
        public void DivideReturnsNegativeNumberIfFirstNumberPositiveSecondNegative()
        {
            var result = calculator.Divide(5, -2);

            Assert.AreEqual(-2.5, result);
        }

        [Test]
        public void DivideReturnsPositiveNumberIfBothNumbersNegative()
        {
            var result = calculator.Divide(-5, -2);

            Assert.AreEqual(2.5, result);
        }

    }
}