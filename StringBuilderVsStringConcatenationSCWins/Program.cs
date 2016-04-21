using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderVsStringConcatenationSCWins
{
    internal class Program
    {
        private static void Main()
        {
            string symbols = "porkalfkgmfdkqodkslaoqdo";

            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(symbols);
                stringBuilder.Append(symbols);
            }
            stopwatch.Stop();
            Console.WriteLine("StringBuilder took " + stopwatch.Elapsed.TotalMilliseconds + " MS");

            var stopwatch2 = Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                string result = symbols + symbols;
                //result = string.Concat(result, symbols);
            }
            stopwatch2.Stop();
            Console.WriteLine("Concat took " + stopwatch2.Elapsed.TotalMilliseconds + " MS");
        }
    }
}
