using System;

namespace ImplicitCasting
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your age, we will display your birth year.");
            byte userValue = Convert.ToByte(Console.ReadLine());

            int birthYear = DateTime.UtcNow.Year - userValue;
            Console.WriteLine(birthYear);
        }
    }
}
