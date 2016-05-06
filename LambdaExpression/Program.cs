using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main()
        {
            //http://www.dotnetperls.com/lambda

            char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
            Random r = new Random();
            List<string> randomStrings = new List<string>();

            for (int j = 0; j < 10000; j++)
            {
                int index1 = r.Next(chars.Length);
                int index2 = r.Next(chars.Length);
                int index3 = r.Next(chars.Length);
                string randomString = $"{chars[index1]}{chars[index2]}{chars[index3]}";
                randomStrings.Add(randomString);    
            }

            List<string> matchedStrings = randomStrings.FindAll(x => x.Contains("a"));
            List<string> matchedStringsWithoutContainedMethod =
                randomStrings.FindAll(symbol => symbol.IndexOf("a"));
            foreach (var matchedString in matchedStrings)
            {
                Console.WriteLine(matchedString);
            }
        }
    }
}
