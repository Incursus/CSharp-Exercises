using System;

namespace Typeof
{
    class Program
    {
        static void Main()
        {
            Type birdType = typeof (Bird);
            Type snakeType = typeof(Snake);

            Console.WriteLine(birdType);
            Console.WriteLine(snakeType);
        }
    }
}
