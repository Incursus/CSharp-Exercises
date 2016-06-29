using System;

namespace UnitTestsBasics
{
    public class Calculator
    {
        public long Multiply(long firstNumber, long secondNumber)
        {
            long result = firstNumber*secondNumber;
            return result;
        }

        public double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber+secondNumber;
            return result;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber-secondNumber;
            return result;
        }

        public decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
