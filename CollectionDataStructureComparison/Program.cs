using System;
using System.Collections.Generic;

namespace CollectionDataStructureComparison
{
    internal class Program
    {
        private static void Main()
        {
            //https://github.com/RehanSaeed/.NET-Big-O-Algorithm-Complexity-Cheat-Sheet/blob/master/Cheat%20Sheet.pdf
            //http://www.vcskicks.com/csharp_data_structures2.php

            var sortedSetNames = new SortedSet<string>();
            var hashSetNames = new HashSet<string>();
            var sortedListNames =  new List<string>();
            sortedListNames.Sort();
            var listNames = new List<string>();

            sortedSetNames.Add("Jonas");
            sortedSetNames.Add("Jonas");
            sortedSetNames.Add("Darius");
            sortedSetNames.Add("Gvidas");

            hashSetNames.Add("Jonas");
            hashSetNames.Add("Jonas");
            hashSetNames.Add("Darius");
            hashSetNames.Add("Gvidas");

            sortedListNames.Add("Jonas");
            sortedListNames.Add("Jonas");
            sortedListNames.Add("Darius");
            sortedListNames.Add("Gvidas");

            listNames.Add("Jonas");
            listNames.Add("Jonas");
            listNames.Add("Darius");
            listNames.Add("Gvidas");

            Console.WriteLine("Hash Set names:");
            foreach (var name in hashSetNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Sorted Set Names:");
            foreach (var name in sortedSetNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Sorted List Names:");
            foreach (var name in sortedListNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("List Names:");
            foreach (var name in listNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
