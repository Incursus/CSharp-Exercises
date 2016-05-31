namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            BellaDotsCoffeeMaker bellaCoffeeMaker = new BellaDotsCoffeeMaker();
            CuisineArtsCoffeeMaker cuisineArtsCoffeeMaker = new CuisineArtsCoffeeMaker();
            HamiltonCoffeeMaker hamiltonCoffeeMaker = new HamiltonCoffeeMaker();

            bellaCoffeeMaker.Brew();
            cuisineArtsCoffeeMaker.Brew();
            hamiltonCoffeeMaker.Brew();
        }
    }
}
