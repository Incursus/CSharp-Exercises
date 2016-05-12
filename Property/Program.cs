using System;

namespace Property
{
    class Program
    {
        private static void Main()
        {
            //http://stackoverflow.com/questions/11159438/looking-for-a-short-simple-example-of-getters-setters-in-c-sharp
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
