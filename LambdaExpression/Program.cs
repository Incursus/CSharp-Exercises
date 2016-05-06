using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main()
        {
            //http://www.codeproject.com/Tips/298963/Understand-Lambda-Expressions-in-minutes

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

            List<string> matchedStringsUsingContains = randomStrings.FindAll(x => x.Contains("a"));
        
            //Without Contains().
            List<string> matchedStringsUsingAny =
                randomStrings.FindAll(symbol => symbol.Any(specificSymbol => specificSymbol == 'a'));

            List<string> matchedStringUsingIndex =
                randomStrings.FindAll(symbol => symbol.IndexOf('a') != -1);

            foreach (var matchedString in matchedStringUsingIndex)
            {
                Console.WriteLine(matchedString);
            }
        }
    }
}
