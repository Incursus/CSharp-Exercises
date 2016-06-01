using System;

namespace InterfacesChoosingOneOfManyInterfaceImplementations
{
    public class CuisineArtsCoffeeMaker : ICoffeeMaker, IFroth
    {
        public void Brew()
        {
            Console.WriteLine("CuisineArts can brew standard coffee");
            Froth();
        }

        public void Froth()
        {
            Console.WriteLine("CuisineArts can brew milk");
        }
    }
}