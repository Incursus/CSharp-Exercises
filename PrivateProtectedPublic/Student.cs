using System;

namespace PrivateProtectedPublic
{
    public class Student : Person
    { 
        private int sessionAverage = 25;

        public void PrintInfo()
        {
         var person = new Student();

            Console.WriteLine("My adress is " + person.Address);
            Console.WriteLine("My age is " + person.Age + ".");
            Console.WriteLine("I study " + sessionAverage + " minutes on average.");
            /*Console.WriteLine("My name is " + person.FirstName);
            Console.WriteLine("My last name is " + person.LastName);*/
            PrintPersonTypeName();
        }
    }
}
