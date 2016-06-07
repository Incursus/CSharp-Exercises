using System;

namespace ConcreteExceptionCatching
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];
            numbers[0] = 5;
            numbers[1] = 6;
            numbers[2] = 2;
            numbers[3] = 3;
            numbers[4] = 11;
            numbers[5] = 12;
            numbers[6] = 1;
            numbers[7] = 0;
            numbers[8] = 4;
            numbers[9] = 7;

            Console.WriteLine("Please choose a number from 1 to 10, and you'll get a corresponding number from the array.");

            try
            {
                short userValue = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine($"The corresponding number in the array is {numbers[userValue - 1]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("This number is not valid please try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Please enter a number, cause you did not.");
            }
        }
    }
}
