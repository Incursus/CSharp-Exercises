using System;
using System.Collections.Generic;

namespace MeasuringMemoryUsage
{
    internal class Program
    {
        private static void Main()
        {
            List<string> listRandomSymbols = new List<string>();
            HashSet<string> hastSetRandomSymbols = new HashSet<string>();

            string symbols = "abcdefghjjklmnobABHWDW)QIJD_QW_D)QW_D>>>>>DMDWQOJD4654891235489569845126598";

            var beforeList = GC.GetTotalMemory(forceFullCollection:false);

            for (int i = 0; i < 1000000; i++)
            {
                listRandomSymbols.Add(symbols + i);
            }

            var afterList = GC.GetTotalMemory(forceFullCollection:false);

            Console.WriteLine($"Before list: {beforeList/(1024*1024)} Megabytes. " +
                              $"After list: {afterList/(1024*1024)} Megabytes. List took up " + ((afterList-beforeList)/(1024*1024)) + " Megabytes of memory.");
            listRandomSymbols.Clear();

            var beforeHashSetMemory = GC.GetTotalMemory(forceFullCollection: true);

            for (int i = 0; i < 1000000; i++)
            {
                hastSetRandomSymbols.Add(symbols + i);
            }

            var afterHashSetMemory = GC.GetTotalMemory(forceFullCollection:false);
            Console.WriteLine($"Before HashSet: {beforeHashSetMemory / (1024 * 1024)} Megabytes. " +
                              $"After HashSet: {afterHashSetMemory / (1024 * 1024)} Megabytes." + " HashSet took up " + ((afterHashSetMemory - beforeHashSetMemory) / (1024 * 1024)) + " Megabytes of memory.");
        }
    }
}

