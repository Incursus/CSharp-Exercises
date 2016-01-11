using System;

namespace Property
{
    class Program
    {
        private static void Main()
        {
            Student person = new Student
            {
                FirstName = "Red",
                Age = 23
            };

            var message = $"{person.FirstName} {person.Age} {person.SkinColor}";
            Console.WriteLine(message);
        }
    }
}
