using System;
using System.IO;
using Newtonsoft.Json;

namespace Deserialization
{
    internal class Program
    {
        //http://www.newtonsoft.com/json
        private static void Main()
        {
            var json = File.ReadAllText("Coffee.json");
            CoffeeMaker coffeeFromGeneric = JsonConvert.DeserializeObject<CoffeeMaker>(json);
            CoffeeMaker coffeeFromObject
                = (CoffeeMaker)JsonConvert.DeserializeObject(json, typeof(CoffeeMaker));

            Console.WriteLine($"{coffeeFromGeneric.Name} {coffeeFromGeneric.PrepareTimeMin}");
            Console.WriteLine($"{coffeeFromObject.Name} {coffeeFromObject.PrepareTimeMin}");
            Console.WriteLine("Test");
        }
    }
}
