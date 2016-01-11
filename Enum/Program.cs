using System;

namespace Enum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 1 for front loader, 2 for top loader, and 3 for a mixed washing machine.");
            var userValue = Convert.ToInt32(Console.ReadLine());

            var enumValue = (WashingMachine) userValue;
            Console.WriteLine(enumValue);
        }
    }
}
