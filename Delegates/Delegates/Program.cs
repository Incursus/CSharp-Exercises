using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        private static void Main()
        {
            List<int> listOfNumbers = new List<int>();

            for (int i = 0; i < 51; i++)
            {
                listOfNumbers.Add(i);
            }

            List<int> listOfEvenNumbers = listOfNumbers.FindAll(FilterByEvenNumber());
            List<int> listOfOddNumbers = listOfNumbers.FindAll(FilterByOddNumber());
            List<int> listOfPrimeNumbers = listOfNumbers.FindAll(FilterByPrimeNumber());

            Console.WriteLine("Even numbers:");
            foreach (int number in listOfEvenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Odd numbers:");
            foreach (int number in listOfOddNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Prime numbers:");
            foreach (int number in listOfPrimeNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        private static Predicate<int> FilterByEvenNumber()
        {
            return delegate(int i) { return IsEven(i); };
        }

        private static Predicate<int> FilterByOddNumber()
        {
            return delegate(int i) { return IsOdd(i); };
        }

        private static Predicate<int> FilterByPrimeNumber()
        {
            return delegate(int i) { return IsPrime(i); };
        } 

        public static bool IsEven(int value)
        {
            return value%2 == 0;
        }

        public static bool IsOdd(int value)
        {
            return value%2 != 0;
        }

        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }
            for (int i = 3; (i*i) <= candidate; i += 2)
            {
                if ((candidate%i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}