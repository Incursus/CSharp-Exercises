using System;

namespace Interfaces
{
    public class HamiltonCoffeeMaker : ICoffeeMaker, IFroth, ICoffeePill
    {
        public void Brew()
        {
            Console.WriteLine("Brewing water wtih Hamilton.");
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