using System;

namespace InterfacesMultipleInheritance
{
    public class HamiltonCoffeeMaker : ICoffeeMaker, IFroth, ICoffeePill
    {
        public void Brew()
        {
            Console.WriteLine("Brewing water wtih Hamilton.");
            Froth();
            UseCofeePill();
        }

        public void Froth()
        {
            Console.WriteLine("Frothing milk...");
        }

        public void UseCofeePill()
        {
            Console.WriteLine("Putting in coffee pill.");
        }
    }
}