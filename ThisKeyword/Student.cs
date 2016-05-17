using System;

namespace ThisKeyword
{
    public class Student
    {
        private string name = null;

        public Student(string name)
        {
           this.name = name;
        }

        public string GetName()
        {
            Console.WriteLine(name);
            return name;
        }
    }
}