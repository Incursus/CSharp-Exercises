using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethordParameters
{
    internal class Program
    {
        private static void Main()
        {
            var result = Calculate(2, 5, "+");
            Calculate(2, 5, "-");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int Calculate(int firstNumber, int secondNumber, string operation)
        {
            int result = 0;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            return result;
        }
    }
}