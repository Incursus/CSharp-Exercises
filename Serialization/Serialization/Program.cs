using System;
using System.IO;
using Newtonsoft.Json;

namespace Serialization
{
    internal class Program
    {
        //https://msdn.microsoft.com/en-us/library/ms233843.aspx
        //http://www.newtonsoft.com/json
        private static void Main()
        {
            CoffeeMaker coffee = new CoffeeMaker();
            string json = JsonConvert.SerializeObject(coffee);

            Console.WriteLine(json);
        }
    }
}
