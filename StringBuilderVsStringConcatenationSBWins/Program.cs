using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderVsStringConcatenationSBWins
{
    internal class Program
    {
        private static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string symbols = "porkalfkgmfdkqodkslaoqdo";

            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                stringBuilder.Append(symbols);
            }
            stopwatch.Stop();
            Console.WriteLine("StringBuilder took " + stopwatch.Elapsed.TotalMilliseconds + " MS");

            string result = null;

            var stopwatch2 = Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                result = result + symbols;
                //result = string.Concat(result, symbols);
            }
            stopwatch2.Stop();
            Console.WriteLine($"{stringBuilder.Length} = {result.Length} {symbols.Length}");
            Console.WriteLine("Concat took " + stopwatch2.Elapsed.TotalMilliseconds + " MS");
        }  
    }
}

