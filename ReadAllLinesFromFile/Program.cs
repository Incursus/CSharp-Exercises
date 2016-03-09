using System;
using System.IO;

namespace ReadAllLinesFromFile
{
    class Program
    {
        public static void Main()
        {
            string[] allLines = File.ReadAllLines("c:\\data.txt");
            foreach (var line in allLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}

