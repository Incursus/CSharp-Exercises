namespace UnitTestsBasics
{
    public class Calculator
    {
        public double Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber*secondNumber;
            return result;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber/secondNumber;
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
        
    }
}
