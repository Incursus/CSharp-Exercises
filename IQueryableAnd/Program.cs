using System;
using System.Collections.Generic;
using System.Linq;

namespace IQueryableAND
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter a last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter a grade average.");
            string gradeAverage = Console.ReadLine();

            List<Student> students = new List<Student>();
            students.Add(new Student { FirstName = "John", LastName = "Ducey", GradeAverage = "6" });
            students.Add(new Student { FirstName = "Peter", LastName = "McLein", GradeAverage = "2" });
            students.Add(new Student { FirstName = "Kyle", LastName = "Tsiatis", GradeAverage = "7" });
            students.Add(new Student { FirstName = "Paul", LastName = "Philipson", GradeAverage = "5" });
            students.Add(new Student { FirstName = "Tom", LastName = "Mcknespiey", GradeAverage = "6" });
            students.Add(new Student { FirstName = "Stephen", LastName = "Trakikas", GradeAverage = "2" });
            students.Add(new Student { FirstName = "Lucke", LastName = "Klatzky", GradeAverage = "1" });
            students.Add(new Student { FirstName = "Jerry", LastName = "Marquis", GradeAverage = "3" });
            students.Add(new Student { FirstName = "Shanty", LastName = "Boyes-watson", GradeAverage = "4" });
            students.Add(new Student { FirstName = "Shadynasty", LastName = "D'epifanio", GradeAverage = "7" });

            IQueryable<Student> studentQuery = null;

            studentQuery = students.AsQueryable()
                 .Where(student => (firstName == "" || student.FirstName == firstName) &&
                                   (lastName == "" || student.LastName == lastName) &&
                                   (gradeAverage == "" || student.GradeAverage == gradeAverage));
     
            
            foreach (var student in studentQuery)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.GradeAverage);
            }
            if (studentQuery.Count() == 0)
            {
                Console.WriteLine("We did not find any students matching your criteria. Please try again.");
            }
        }
    }
}
