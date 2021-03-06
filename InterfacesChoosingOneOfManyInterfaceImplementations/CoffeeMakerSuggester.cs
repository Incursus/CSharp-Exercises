﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfacesChoosingOneOfManyInterfaceImplementations
{
    public class CoffeeMakerSuggester
    {
        public void SuggestCoffeeMaker()
        {
            Console.WriteLine("Do you like your coffee with milk? Type Y (yes) or N (no)?");
            string userMilkValue = Console.ReadLine().ToUpper();

            Console.WriteLine(
                "Do you prefer your coffee from a pill (quick n' easy but doesn't taste as good)? Type Y (yes) or N (no)");
            string userCoffeePillValue = Console.ReadLine().ToUpper();

            List<ICoffeeMaker> coffeeMakers = new List<ICoffeeMaker>();
            coffeeMakers.Add(new BellaDotsCoffeeMaker());
            coffeeMakers.Add(new CuisineArtsCoffeeMaker());
            coffeeMakers.Add(new HamiltonCoffeeMaker());
            coffeeMakers.Add(new BrilleCoffeeMaker());

            IQueryable<ICoffeeMaker> queryable = coffeeMakers
                .Where(maker => (userMilkValue == "N" || (maker as IFroth) != null) &&
                                (userCoffeePillValue == "N" || (maker as ICoffeePill) != null))
                .AsQueryable();

            ICoffeeMaker foundCoffeeMaker = queryable.FirstOrDefault();
            Console.WriteLine($"We found this coffee maker: {foundCoffeeMaker?.GetType().Name}");  
        }
    }
}