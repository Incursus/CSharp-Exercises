using System;
using System.Threading;

namespace ThreadingCreationAndUsage
{
    class Program
    {
        class ThreadingCreationAndUsage
        {
           
            static void Main()
            {
                ThreadStart thread1Start = CallToThread1;
                ThreadStart thread2Start = CallToThread2;
                Thread thread1 = new Thread(thread1Start);
                Thread thread2 = new Thread(thread2Start);
                thread1.Start();
                thread2.Start();
                Console.ReadKey();
            }

            public static void CallToThread1()
            {
                Console.WriteLine("Thread 1");
            }

            public static void CallToThread2()
            {
                Console.WriteLine("Thread 2");
            }
        }
    }
}
