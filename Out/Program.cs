using System;

namespace Out
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please write a number. This number will multiply by itself.");
            string userValue = Console.ReadLine();

            int result;
            bool isParsed = int.TryParse(userValue, out result);

            if (isParsed)
            {
                Console.WriteLine(result * result);                
            }
            else
            {
                Console.WriteLine("You did something wrong typing: " + userValue);
            }
        }
    }
}
