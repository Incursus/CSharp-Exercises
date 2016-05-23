using System;

namespace ReferenceTypeVsValueType
{
    class Program
    {
        static void Main()
        {
            //http://www.albahari.com/valuevsreftypes.aspx
            //http://stackoverflow.com/questions/2330767/what-is-the-difference-between-instantiated-and-initialized
            //Reference type. Reference types are referenced (not being copied)/point to the same object.
            Console.WriteLine("Changing student name via method from Kajon to Redas");
            Student student = new Student();
            student.Name = "Kajon";
            Change(student);
            Console.WriteLine($"Result: {student.Name}");

            //Value type. Value types are copied when used as method params or using assignment (=) operator.
            var name = "Kajon";
            Console.WriteLine("Changing name variable from Kajon to Redas");
            Change(name);
            Console.WriteLine($"Result: {name}");
        }

        public static void Change(Student student)
        {
            student.Name = "Redas";
        }

        public static void Change(string studentName)
        {
            studentName = "Redas";
        }
    }
}
