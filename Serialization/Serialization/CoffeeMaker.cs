using System;

namespace Serialization
{
    public class CoffeeMaker
    {
        public string Name { get; set; }
        public int PrepareTimeMin { get; set; }

        public CoffeeMaker(string n, int p)
        {
            Name = n;
            PrepareTimeMin = p;
        }
    }
}
