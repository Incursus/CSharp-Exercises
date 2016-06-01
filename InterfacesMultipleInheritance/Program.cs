namespace InterfacesMultipleInheritance
{
    class Program
    {
        static void Main()
        {
            ICoffeeMaker bellaCoffeeMaker = new BellaDotsCoffeeMaker();
            ICoffeeMaker cuisineArtsCoffeeMaker = new CuisineArtsCoffeeMaker();
            ICoffeeMaker hamiltonCoffeeMaker = new HamiltonCoffeeMaker();

            bellaCoffeeMaker.Brew();
            cuisineArtsCoffeeMaker.Brew();
            hamiltonCoffeeMaker.Brew();
        }
    }
}
