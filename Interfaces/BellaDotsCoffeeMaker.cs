using System;

namespace Interfaces
{
    public class BellaDotsCoffeeMaker : ICoffeeMaker
    {
        public void Brew()
        {
            Console.WriteLine("Brewing standard coffee with BellaDots.");
        }
    }
}