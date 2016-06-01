using System;

namespace InterfacesMultipleInheritance
{
    public class CuisineArtsCoffeeMaker : ICoffeeMaker, IFroth
    {
        public void Brew()
        {
            Console.WriteLine("Brewing standard coffee with CuisineArts.");
            Froth();
        }

        public void Froth()
        {
            Console.WriteLine("Frothing milk.");
        }
    }
}