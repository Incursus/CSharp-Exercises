using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main()
        {
            PrintNumbersWithContinue();
        }

        public static void PrintNumbersWithContinue()
        {
            int number;
            for (number = 0; number <= 10; number++)
            {
                if (number == 4)
                {
                    continue;
                }
                Console.WriteLine(number);
            }
        }
    }
}
