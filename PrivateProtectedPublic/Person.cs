using System;

namespace PrivateProtectedPublic
{
    public abstract class Person
    {
        public string FirstName = "Darius";
        public string LastName = "Kriksciukaitis";
        protected int Age = 23;
        private string typeName = "I am a black typeName.";
        protected string Address = "Jovarų gatvė.";

        public int YearOfBirth { get; set; }

        protected Person()
        {
            YearOfBirth = 1992;
        }

        public void SetTypeName(string input)
        {
            typeName = input;
        }

        public string GetTypeName()
        {
            return typeName;
        }

        public void PrintPersonTypeName()
        {
            Console.WriteLine("My typeName is " + typeName);
        }
    }
}
