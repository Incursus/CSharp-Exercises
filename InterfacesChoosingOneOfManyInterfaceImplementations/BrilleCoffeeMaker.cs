using System;

namespace InterfacesChoosingOneOfManyInterfaceImplementations
{
    public class BrilleCoffeeMaker : ICoffeeMaker, ICoffeePill
    {
        public void Brew()
        {
            Console.WriteLine("Brille is brewing...");
            UseCoffeePill();
        }

        public void UseCoffeePill()
        {
            Console.WriteLine("Brille is making coffee from a coffee pill.");
        }
    }
}