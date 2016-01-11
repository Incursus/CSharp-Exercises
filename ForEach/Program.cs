using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        public static int ListSize = 101;

        static void Main()
        {
            Random random = new Random();
            List<int> grades = new List<int>(ListSize);

            while (grades.Count <= 100)
            {
                grades.Add(random.Next(ListSize));
            }

            List<int> filteredGrades = new List<int>();
 
            foreach (int grade in grades)
            {
                if (grade >= 60)
                {
                    filteredGrades.Add(grade);
                }
            }
          
            Console.WriteLine("These are the {0} grades that passed the exam out of an overall of 101 students", filteredGrades.Count);

            foreach (int grade in filteredGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
