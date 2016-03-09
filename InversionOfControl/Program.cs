using System;

namespace InversionOfControl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var grinder = new CoffeeGrinder();
            grinder.Beans = new LavazzaBeans();
            grinder.Beans = new PeliniBeans();
            grinder.Start();
        }
    }

    public class CoffeeGrinder
    {
        public IBeans Beans { get; set; }

        public void Start()
        {
            Console.WriteLine($"Grinding {Beans.Name} beans...");
        }
    }

    public class PeliniBeans : IBeans
    {
        public string Name { get; set; } = "Pelini";
    }

    public class LavazzaBeans : IBeans
    {
        public string Name { get; set; } = "Lavazza";
    }

    public interface IBeans
    {
         string Name { get; set; }
    }
}
