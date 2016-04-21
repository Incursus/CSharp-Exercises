using System;
using System.Collections.Generic;
using System.IO;

namespace Stream
{
    internal class Program
    {
        private static void Main()
        {
            PrepareTestFile();
            Console.WriteLine(GetAllLineSumFromFile());
        }

        public static void PrepareTestFile()
        {
            Random random = new Random();
            List<string> randomNumbers = new List<string>();

            while (randomNumbers.Count <= 10000000)
            {
                randomNumbers.Add(random.Next(100).ToString());
            }

            File.WriteAllLines("RandomNumbers.txt", randomNumbers);
        }

        public static int GetAllLineSumFromFile()
        {
            var sum = 0;
            using (FileStream fileStream = new FileStream("RandomNumbers.txt", FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        sum = int.Parse(line) + sum;
                    }
                }
            }

            return sum;
        }
    }
}
