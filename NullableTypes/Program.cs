using System;
using System.Collections.Generic;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            List<int?> randomList = new List<int?>();
            Random random = new Random();

            List<int?> fixedValueList = new List<int?> {1, -1, null};

            for (int i = 0; i < 10; i++)
            {
                var index = random.Next(0, 3);
                var randomValue = fixedValueList[index];
                randomList.Add(randomValue);
            }

            foreach (var element in randomList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
