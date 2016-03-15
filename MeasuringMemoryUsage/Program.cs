using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MeasuringMemoryUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listRandomSymbols = new List<string>();
            HashSet<string> hastSetRandomSymbols = new HashSet<string>();

            string symbols = "abcdefghjjklmnobABHWDW)QIJD_QW_D)QW_D>>>>>DMDWQOJD4654891235489569845126598";

            for (int i = 0; i < 100000; i++)
            {
                listRandomSymbols.Add(symbols + i);
                hastSetRandomSymbols.Add(symbols + i);
            }

            Process memory = new Process();
            //memory.PagedSystemMemorySize64(listRandomSymbols);
            var listMemory = Process.GetProcesses(listRandomSymbols.ToString());
            var hashSetMemory = Process.GetProcesses(hastSetRandomSymbols.ToString());

            Console.WriteLine(listMemory.ToString());
            Console.WriteLine(hashSetMemory.ToString());
        }
    }
}
