using System;
﻿using System.Collections.Generic;

namespace CollectionDataStructureComparison
{
    internal class Program
    {
        private static void Main()
        {
            //https://github.com/RehanSaeed/.NET-Big-O-Algorithm-Complexity-Cheat-Sheet/blob/master/Cheat%20Sheet.pdf
            //http://www.vcskicks.com/csharp_data_structures2.php

            HandleSortedSet();
            HandleHashSet();
            HandleSortedList();
            HandleList();
        }

        private static void HandleList()
        {
            var listNames = new List<string> {"Jonas", "Jonas", "Darius", "Gvidas"};

            Console.WriteLine("List Names:");
            Print(listNames);
            Console.WriteLine("");
        }

        private static void HandleSortedList()
        {
            var sortedListNames = new List<string> {"Jonas", "Jonas", "Darius", "Gvidas"};
            sortedListNames.Sort();

            Console.WriteLine("Sorted List Names:");
            Print(sortedListNames);
        }

        private static void HandleHashSet()
        {
            var hashSetNames = new HashSet<string>();
            hashSetNames.Add("Jonas");
            hashSetNames.Add("Jonas");
            hashSetNames.Add("Darius");
            hashSetNames.Add("Gvidas");

            Console.WriteLine("Hash Set names:");
            Print(hashSetNames);
        }

        private static void HandleSortedSet()
        {
            var sortedSetNames = new SortedSet<string>();
            sortedSetNames.Add("Jonas");
            sortedSetNames.Add("Jonas");
            sortedSetNames.Add("Darius");
            sortedSetNames.Add("Gvidas");

            Console.WriteLine("Sorted Set Names:");
            Print(sortedSetNames);
        }

        public static void Print<T>(IEnumerable<T> elements)
        {
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}

