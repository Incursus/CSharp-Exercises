using System;

namespace Serialization
{
    public class CoffeeMaker
    {
<<<<<<< HEAD
        public string Name { get; set; } = "Jacobs";
        public int PrepareTimeMin { get; set; } = 5;
=======
        public string Name { get; set; }
        public int PrepareTimeMin { get; set; }

        public CoffeeMaker(string n, int p)
        {
            Name = n;
            PrepareTimeMin = p;
        }
>>>>>>> 8aca9171e4ba3be44e9bb2fd09ca5c74c7e12edf
    }
}
