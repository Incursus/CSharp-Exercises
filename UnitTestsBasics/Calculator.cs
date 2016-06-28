namespace UnitTestsBasics
{
    public class Calculator
    {
        public int Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber*secondNumber;
            return result;
        }

        public int Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber/secondNumber;
            return result;
        }

        public int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber+secondNumber;
            return result;
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            int result = firstNumber-secondNumber;
            return result;
        }
        
    }
}
