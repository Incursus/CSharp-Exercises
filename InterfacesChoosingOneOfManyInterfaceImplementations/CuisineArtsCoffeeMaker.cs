using System;

namespace InterfacesChoosingOneOfManyInterfaceImplementations
{
    public class CuisineArtsCoffeeMaker : ICoffeeMaker, IFroth
    {
        public void Brew()
        {
            Console.WriteLine("CuisineArts can brew standard coffee");
            Froth();

            var brewCoffee = true;
            var coffeePill = false;
            var frothMilk = true;
        }

        public void Froth()
        {
            Console.WriteLine("CuisineArts can brew milk");
        }
    }
}