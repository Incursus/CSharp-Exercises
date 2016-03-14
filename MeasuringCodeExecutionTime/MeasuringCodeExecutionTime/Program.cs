using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MeasuringCodeExecutionTime
{
    internal class Program
    {
        //HashSet suranda ~100k kartų greičiau nei list.
        private static void Main()
        {
            List<string> listRandomSymbols = new List<string>();
            HashSet<string> hastSetRandomSymbols = new HashSet<string>();

            string symbols = "abcdefghjjklmnobABHWDW)QIJD_QW_D)QW_D>>>>>DMDWQOJD4654891235489569845126598";

            for (int i = 0; i < 100000; i++)
            {
                listRandomSymbols.Add(symbols + i);
                hastSetRandomSymbols.Add(symbols + i);
            }

            CheckContains(listRandomSymbols);
            CheckContains(hastSetRandomSymbols);

            var stopwatch = Stopwatch.StartNew();
            CheckContains(hastSetRandomSymbols);
            stopwatch.Stop();
            Console.WriteLine("HashSet search took " + stopwatch.Elapsed);


            var stopwatch2 = Stopwatch.StartNew();
            CheckContains(listRandomSymbols);
            stopwatch2.Stop();
            Console.WriteLine("List search took " + stopwatch2.Elapsed);
        }

        private static void CheckContains(List<string> listRandomSymbols)
        {
            for (int i = 0; i < 100; i++)
            {
                listRandomSymbols.Contains("DMD");
            }
        }

        private static void CheckContains(HashSet<string> hastSetRandomSymbols)
        {
            for (int i = 0; i < 100; i++)
            {
                hastSetRandomSymbols.Contains("DMD");
            }
        }
    }
}
