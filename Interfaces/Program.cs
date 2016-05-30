using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            BellaDotsCoffeeMaker bellaCoffeeMaker = new BellaDotsCoffeeMaker();
            CuisineArtsCoffeeMaker cuisineArtsCoffeeMaker = new CuisineArtsCoffeeMaker();
            HamiltonCoffeeMaker hamiltonCoffeeMaker = new HamiltonCoffeeMaker();

            bellaCoffeeMaker.Brew();
            cuisineArtsCoffeeMaker.Brew();
            cuisineArtsCoffeeMaker.Froth();
            hamiltonCoffeeMaker.Brew();
            hamiltonCoffeeMaker.Froth();
            hamiltonCoffeeMaker.UseCofeePill();
        }
    }
}
