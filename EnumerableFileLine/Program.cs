using System;
using System.Collections.Generic;
using System.IO;

namespace EnumerableFileLine
{
    class Program
    {
        static void Main()
        {
            var fileLines = ReadFrom("C:\\data.txt");
            foreach (string fileLine in fileLines)
            {
                Console.WriteLine(fileLine);
                if (fileLine.Contains("o gal ir ne kas čia"))
                {
                    break;
                }
            }
        }
        
        static IEnumerable<string> ReadFrom(string file)
        {
            using (StreamReader reader = File.OpenText(file))
            {
                string line;

                do
                {
                    line = reader.ReadLine();
                    yield return line;
                } 
                while (line != null);
            }
        }
    }
}
