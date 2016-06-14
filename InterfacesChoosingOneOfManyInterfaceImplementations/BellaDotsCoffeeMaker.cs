using System;

namespace InterfacesChoosingOneOfManyInterfaceImplementations
{
    public class BellaDotsCoffeeMaker : ICoffeeMaker
    {
        public void Brew()
        {
            Console.WriteLine("BellaDots can brew standard coffee.");
        }
    }
}