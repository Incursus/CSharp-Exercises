using System;

namespace Recursion
{
    class Program
    {
        private static void WriteTextRepeatedly(string text, int count)
        {
            if (count == 0)
                return;
        
            Console.WriteLine(text);
            count--;

            WriteTextRepeatedly(text, count);
        }

        static void Main()
        {
            WriteTextRepeatedly("jfff",  3);
        }
    }
}
