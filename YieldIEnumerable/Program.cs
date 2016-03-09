using System;
using System.Collections.Generic;

namespace Enumereble
{
    internal class Program
    {
        private static void Main()
        {
            /* The function returns an object that implements the IEnumerable interface. 
If a calling function starts foreach-ing over this object the function is called again until it "yields". 
This is syntactic sugar introduced in C# 2.0. In earlier versions you had to create your own IEnumerable and IEnumerator objects to do stuff like this.
The easiest way understand code like this is to type in an example, set some breakpoints and see what happens.
Try stepping through this for example:*/

            IEnumerable<int> enumerable = GetIntegers();

            foreach (int number in enumerable)
            {
                Console.WriteLine(number);
            }
        }

        public static IEnumerable<int> GetIntegers()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield break;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }
    }
}
