using System;

namespace InterfacesChoosingOneOfManyInterfaceImplementations
{
    public class CoffeeMakerSuggester
    {
        public void SuggestCoffeeMaker()
        {
            Console.WriteLine("Do you like your coffee with milk? Type Y (yes) or N (no)?");
            string userMilkValue = Console.ReadLine().ToUpper();

            Console.WriteLine("Do you prefer your coffee from a pill (quick n' easy but doesn't taste as good)? Type Y (yes) or N (no)");
            string userCoffeePillValue = Console.ReadLine().ToUpper();

            ICoffeeMaker bellaCoffeeMaker = new BellaDotsCoffeeMaker();
            ICoffeeMaker cuisineArtsCoffeeMaker = new CuisineArtsCoffeeMaker();
            ICoffeeMaker hamiltonCoffeeMaker = new HamiltonCoffeeMaker();
            ICoffeeMaker brilleCoffeeMaker = new BrilleCoffeeMaker();

            if (userMilkValue == "Y" && userCoffeePillValue == "N")
            {
                cuisineArtsCoffeeMaker.Brew();
            }
            if (userMilkValue == "Y" && userCoffeePillValue == "Y")
            {
                hamiltonCoffeeMaker.Brew();
            }
            if (userMilkValue == "N" && userCoffeePillValue == "N")
            {
                bellaCoffeeMaker.Brew();
            }
            if (userMilkValue == "N" && userCoffeePillValue == "Y")
            {
                brilleCoffeeMaker.Brew();
            }
        }
    }
}