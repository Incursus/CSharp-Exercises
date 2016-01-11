using System;

namespace Params
{
    class Program
    {
        static void Main()
        {
            int firstSum = Multiply(2, 2, 2);
            int secondSum = Multiply(2, 2);

            Console.WriteLine(firstSum);
            Console.WriteLine(secondSum);
        }

        static int Multiply(params int[] values)
        {
            int total = 1;
            foreach (var value in values)
            {
                total *= value;
            }
            return total;
        }
    }
}
