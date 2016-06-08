using System;

namespace InterfacesChoosingOneOfManyInterfaceImplementations
{
    public class BrilleCoffeeMaker : ICoffeeMaker, ICoffeePill
    {
        public void Brew()
        {
            Console.WriteLine("Brille is brewing...");
            UseCoffeePill();

            var brewCoffee = true;
            var coffeePill = true;
            var frothMilk = false;
        }

        public void UseCoffeePill()
        {
            Console.WriteLine("Brille is making coffee from a coffee pill.");
        }
    }
}