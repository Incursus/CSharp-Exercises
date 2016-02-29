using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;

namespace ThreadingThreadSafeEntities
{
    internal class Program
    {
        private static void Main()
        {
            ConcurrentBag<int> numbers = new ConcurrentBag<int>();

            Thread thread1 = new Thread(() =>
            {
                Console.WriteLine("Thread 1");

                for (int i = 0; i < 1000; i++)
                {
                    Thread.Sleep(1);
                    Console.WriteLine($"Adding {i} from Thread 1");
                    numbers.Add(i);
                }
            });
            Thread thread2 = new Thread(() => CallToThread2(numbers));
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }

        public static void CallToThread2(ConcurrentBag<int> numbers)
        {
            Console.WriteLine("Thread 2");

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
                Console.WriteLine($"Any: {numbers.Any()} from Thread 2");
            }
        }
    }
}
