using System;

namespace TryCatchFinally
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please enter a number. We will multiply this number by itself.");

            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                int result = userInput/userInput;
                Console.WriteLine("{0} multiplied by {0} is equal to {1}. Have a nice day!", userInput, result);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Oops. You divided by zero. Error message:" + exception.Message + " Please try again!");
            }
            catch (FormatException exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Oops. Something went wrong. We encountered an error:" + exception.Message + " Please try again!");
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("The program is closing. I hope you are satisfied with your experience. If not contact customer support at Twitch.tv/Kappa");
            }
        }
    }
}
