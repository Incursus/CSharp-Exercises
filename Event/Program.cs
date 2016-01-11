using System;

namespace Event
{
    public delegate void EventHandler();

    class Program
    {
        public static event EventHandler inputHandler;
        public static string userValue;

        //http://www.dotnetperls.com/event
        static void Main()
        {
            userValue = Console.ReadLine();
            inputHandler += new EventHandler(PrintUserValue);
            inputHandler += new EventHandler(TryToGetSquare);
            inputHandler.Invoke();
            inputHandler -= PrintUserValue;
            inputHandler -= TryToGetSquare;

            Console.ReadLine();
        }

        static void PrintUserValue()
        {
            Console.WriteLine("You entered " + userValue);
        }

        static void TryToGetSquare()
        {
            decimal value;
            var parsed = decimal.TryParse(userValue, out value);
            if (parsed)
            {
                Console.WriteLine(value * value);
            }
            else
            {
                Console.WriteLine("Cannot get square");
            }
        }
    }
}
