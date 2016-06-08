using System;

namespace InterfacesChoosingOneOfManyInterfaceImplementations
{
    public class BellaDotsCoffeeMaker : ICoffeeMaker
    {
        public void Brew()
        {
            Console.WriteLine("BellaDots can bew standard coffee.");

            var brewCoffee = true;
            var coffeePill = false;
            var frothMilk = false;
        }
    }
}