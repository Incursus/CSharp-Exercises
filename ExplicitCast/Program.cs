using System;

namespace ExplicitCast
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your weight in xx.xx form (with decimal) we will print a numeric value for you.");
            decimal userValue = Convert.ToDecimal(Console.ReadLine());

            int roundedWeight = (int) userValue;
            Console.WriteLine("Your approximate weight is {0}", roundedWeight);
        }
    }
}
