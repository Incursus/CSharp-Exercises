using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ThreadingLock
{
    internal class Program
    {
        private static readonly object LockObject = new object();

        private static void Main()
        {
            List<int> numbers = new List<int>();

            Thread thread1 = new Thread(() =>
            {
                Console.WriteLine("Thread 1");

                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"Adding {i} from Thread 1");
                    Thread.Sleep(1);
                    lock (LockObject)
                    {
                        numbers.Add(i);
                    }
                }
            });
            Thread thread2 = new Thread(() => CallToThread2(numbers));
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }

        public static void CallToThread2(List<int> numbers)
        {
            Console.WriteLine("Thread 2");

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);

                lock (LockObject)
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine($"Removing {i} from Thread 2");

                        numbers.Remove(numbers.Last());
                    }
                }
            }
        }
    }
}
