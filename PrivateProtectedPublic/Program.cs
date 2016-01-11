using System;

namespace PrivateProtectedPublic
{
    class Program
    {
        static void Main()
        {
            var student = new Student();
            var professor = new Professor();

           /* Type personType = typeof (Person);
            FieldInfo personInfo = Person.GetField(student, personType);

                Console.WriteLine(personInfo);*/


            Console.WriteLine(student.GetTypeName());
            student.SetTypeName("Juodas blondinas");
            Console.WriteLine(student.GetTypeName());

            Console.WriteLine(student.YearOfBirth);
            student.YearOfBirth = 2000;
            Console.WriteLine(student.YearOfBirth);

            /*student.PrintInfo();
            professor.PrintSalary();*/
        }
    }
}
