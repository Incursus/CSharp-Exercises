using System;
using System.Collections.Generic;
using System.Linq;

namespace IQueryableOr
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please enter a first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter a last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter a grade average.");
            string gradeAverage = Console.ReadLine();

            List<Student> students = new List<Student>();
            students.Add(new Student {FirstName = "John", LastName = "Ducey", GradeAverage = "6"});
            students.Add(new Student {FirstName = "Peter", LastName = "McLein", GradeAverage = "2"});
            students.Add(new Student {FirstName = "Kyle", LastName = "Tsiatis", GradeAverage = "7"});
            students.Add(new Student {FirstName = "Paul", LastName = "Philipson", GradeAverage = "5"});
            students.Add(new Student {FirstName = "Tom", LastName = "Mcknespiey", GradeAverage = "6"});
            students.Add(new Student {FirstName = "Stephen", LastName = "Trakikas", GradeAverage = "2"});
            students.Add(new Student {FirstName = "Lucke", LastName = "Klatzky", GradeAverage = "1"});
            students.Add(new Student {FirstName = "Jerry", LastName = "Marquis", GradeAverage = "3"});
            students.Add(new Student {FirstName = "Shanty", LastName = "Boyes-watson", GradeAverage = "4"});
            students.Add(new Student {FirstName = "Shadynasty", LastName = "D'epifanio", GradeAverage = "7"});

            IQueryable<Student> studentQuery = null;           

            if (firstName != "")
            {
                studentQuery =
                    students.AsQueryable()
                        .Where(
                            student =>
                                student.FirstName == firstName);
            }

            if (lastName != "")
            {
                studentQuery = students.AsQueryable().Where(student => student.LastName == lastName);
            }

            if (gradeAverage != "")
            {
                studentQuery = students.AsQueryable().Where(student => student.GradeAverage == gradeAverage);
            }

            if (studentQuery == null || studentQuery.Count() == 0)
            {
                Console.WriteLine("We didn't find anything.");
            }

            foreach (var student in studentQuery)
            {
                Console.WriteLine(
                         "{0} {1} with an {2} grade average.",
                         student.FirstName, student.LastName, student.GradeAverage);
            }
        }
    }
}
