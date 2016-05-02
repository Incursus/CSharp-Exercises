using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PLINQ
{
    class Program
    {
        private static void Main()
        {
            //http://www.dotnetperls.com/asparallel
            List<long> elements = new List<long>();
            for (int i = 1; i <= 100000000; i++)
            {
                elements.Add(i);
            }

            var stopwatch = Stopwatch.StartNew();
            var sum = elements.Sum();
            stopwatch.Stop();
            Console.WriteLine("Sum of all elements took " + stopwatch.Elapsed.TotalMilliseconds + " MS");

            stopwatch = Stopwatch.StartNew();
            var parallelSum = elements.AsParallel().Sum();
            stopwatch.Stop();
            Console.WriteLine("Sum of all elements with parallel took " + stopwatch.Elapsed.TotalMilliseconds + " MS");

        }
    }
}
