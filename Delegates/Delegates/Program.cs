using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();

            for (int i = 0; i < 51; i++)
            {
                listOfNumbers.Add(i);
            }

            List<int> listOfEvenNumbers = new List<int>();
            List<int> listOfOddNumbers = new List<int>();
            List<int> listOfPrimeNumbers = new List<int>();
            
        }

        private static Predicate<int> FilterByEvenNumber()
        {
            return delegate 
        } 

        public static bool IsEven(int value)
        {
            return value%2 == 0;
        }
    }
}
