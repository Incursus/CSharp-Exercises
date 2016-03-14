using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MeasuringCodeExecutionTime
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            List<string> listRandomSymbols = new List<string>();
            HashSet<string> hastSetRandomSymbols = new HashSet<string>();

            string symbols = "abcdefghjjklmnobABHWDW)QIJD_QW_D)QW_D>>>>>DMDWQOJD4654891235489569845126598";
            Random random = new Random();

            if (listRandomSymbols.Count < 100000)
            {
                listRandomSymbols.Add(random.Next(symbols.Length).ToString());
            }

            stopwatch.Start();
            listRandomSymbols.Contains("DMD");
            Console.WriteLine("List search took " + stopwatch.Elapsed);
            stopwatch.Stop();

            if (hastSetRandomSymbols.Count < 100000)
            {
                hastSetRandomSymbols.Add(random.Next(symbols.Length).ToString());
            }

            stopwatch.Start();
            listRandomSymbols.Contains("123");
            Console.WriteLine("Hash Set search took " + stopwatch.Elapsed);
            stopwatch.Stop();


        }
    }
}
