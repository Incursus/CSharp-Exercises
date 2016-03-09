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
<<<<<<< HEAD
            CoffeeMaker coffee = new CoffeeMaker();
            string json = JsonConvert.SerializeObject(coffee);

            Console.WriteLine(json);
=======
            string text = "lol";
            string json = JsonConvert.SerializeObject(text);
>>>>>>> 8aca9171e4ba3be44e9bb2fd09ca5c74c7e12edf
        }
    }
}
