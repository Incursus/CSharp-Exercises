using System;

namespace InvertedEnum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 'Front', 'Top' or 'Mixed' and we'll tell you which machine does what");
            var userValue = Console.ReadLine();
            var parsedValue = Enum.Parse(typeof(WashingMachine), userValue);

            Console.WriteLine("You need {0} from the left", (int)parsedValue);
        }
    }
}
