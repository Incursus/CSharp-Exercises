using System;

namespace PostfixVsPrefixOperators
{
    class Program
    {
        //https://msdn.microsoft.com/en-us/library/36x43w8w.aspx
        static void Main()
        {
            int firstNumber = 5;
            int secondNumberPostIncrement = firstNumber++;
            Console.WriteLine(secondNumberPostIncrement);

            firstNumber = 5;
            int secondNumberPreIncrement = ++firstNumber;
            Console.WriteLine(secondNumberPreIncrement);
        }
    }
}
