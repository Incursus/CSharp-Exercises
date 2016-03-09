using System;

namespace Case
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number from 1 to 10 and we'll tell you the type of the washing machine.");
            var userValue = Convert.ToInt16(Console.ReadLine());

            switch (userValue)
            {
                case 1:
                {
                    Console.WriteLine("This is a front loader.");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("This is a top loader.");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("This is a mixed one.");
                    break;
                }
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                {
                    Console.WriteLine("This is a samsung washing machine. It turns into a future transformer.");
                    break;
                }
                default:
                {
                    Console.WriteLine("We're sorry, such a machine doesn't exist in our system.");
                    break;
                }
            }
        }
    }
}
