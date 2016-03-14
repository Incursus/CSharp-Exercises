using System;
using System.Collections.Generic;

namespace GenericsMethodUsage
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>();
            List<int> grades = new List<int>();
            List<short> ages = new List<short>();

            names.Add("John");
            names.Add("Red");
            names.Add("Darius");
            names.Add("Gvidas");
            names.Add("Shadynasty");
            names.Add("Bob");
            names.Add("Ross");
            names.Add("Michelle");
            names.Add("Dovilė");
            names.Add("Sophie");

            grades.Add(5);
            grades.Add(6);
            grades.Add(7);
            grades.Add(8);
            grades.Add(9);
            grades.Add(6);
            grades.Add(7);
            grades.Add(8);
            grades.Add(4);
            grades.Add(2);

            string secondName = GetSecondElement(names);
            Console.WriteLine($"Second name: {secondName}");
            int secondGrade = GetSecondElement(grades);
            Console.WriteLine($"Second grade: {secondGrade}");
            short secondAge = GetSecondElement(ages);
            Console.WriteLine($"Second age: {secondAge}");
        }

        static T GetSecondElement<T>(List<T> list)
        {
            return list[1];
        }
    }

}
