using System;

namespace Default
{
    class Program
    {
        //https://msdn.microsoft.com/en-us/library/83fhsxwc.aspx
        static void Main()
        {
            string userValue = null;

            while (userValue != "q")
            {
                Console.WriteLine("Enter a c# type (int, bool, string) and we will give you its default value. To quit type 'q'");
                userValue = Console.ReadLine().ToLower();

                if (userValue == "int")
                {
                    Console.WriteLine(default(int));
                }
                else if (userValue == "bool")
                {
                    Console.WriteLine(default(bool));
                }
                else if (userValue == "string")
                {
                    Console.WriteLine(default(string));
                }
                else
                {
                    Console.WriteLine("No valid type found please try again.");
                }
            }

            Console.WriteLine("Program exitting.");
            Console.ReadLine();
        }
    }
}


