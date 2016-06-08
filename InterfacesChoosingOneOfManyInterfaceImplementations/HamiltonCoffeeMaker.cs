using System;

namespace InterfacesChoosingOneOfManyInterfaceImplementations
{
    public class HamiltonCoffeeMaker : ICoffeeMaker, IFroth, ICoffeePill
    {
        public void Brew()
        {
            Console.WriteLine("Hamilton can bew regular coffee.");
            Froth();
            UseCoffeePill();
        }

        public void Froth()
        {
            Console.WriteLine("Hamilton can froth milk.");
        }

        public void UseCoffeePill()
        {
            Console.WriteLine("Hamilton can use coffee pills.");
        }

    }
}