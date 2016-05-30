using System;

namespace Interfaces
{
    public class CuisineArtsCoffeeMaker : ICoffeeMaker, IFroth
    {
        public void Brew()
        {
            Console.WriteLine("Brewing standard coffee with CuisineArts.");
        }

        public void Froth()
        {
            Console.WriteLine("Frothing milk.");
        }
    }
}