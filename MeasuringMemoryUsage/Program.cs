using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MeasuringMemoryUsage
{
    class Program
    {
        private static void Main()
        {
            Process process = Process.GetCurrentProcess();
            var workingSetBefore = process.WorkingSet64;
            Console.WriteLine($"Before list: {workingSetBefore}");

            List<string> listRandomSymbols = new List<string>();
            HashSet<string> hastSetRandomSymbols = new HashSet<string>();

            string symbols = "abcdefghjjklmnobABHWDW)QIJD_QW_D)QW_D>>>>>DMDWQOJD4654891235489569845126598";

            for (int i = 0; i < 1000000; i++)
            {
                listRandomSymbols.Add(symbols + i);
            }

            process = Process.GetCurrentProcess();
            Console.WriteLine($"After list: {process.WorkingSet64}");
            Console.WriteLine("Memory allocated: " + ((process.WorkingSet64 - workingSetBefore)/(1024*1024)) +
                              " Megabytes");

            listRandomSymbols.Clear();
            listRandomSymbols = null;
            GC.Collect();

            process = Process.GetCurrentProcess();
            workingSetBefore = process.WorkingSet64;
            Console.WriteLine($"Before HashSet: {workingSetBefore}");

            for (int i = 0; i < 1000000; i++)
            {
                hastSetRandomSymbols.Add(symbols + i);
            }

            process = Process.GetCurrentProcess();
            Console.WriteLine($"After HashSet: {process.WorkingSet64}");
            Console.WriteLine("Memory allocated: " + ((process.WorkingSet64 - workingSetBefore)/(1024*1024)) +
                              " Megabytes");
        }


        //memory.PagedSystemMemorySize64(listRandomSymbols);
            /*var listMemory = Process.GetProcesses(listRandomSymbols.ToString());
            var hashSetMemory = Process.GetProcesses(hastSetRandomSymbols.ToString());

            Console.WriteLine(listMemory.ToString());
            Console.WriteLine(hashSetMemory.ToString());*/
        }
    }

