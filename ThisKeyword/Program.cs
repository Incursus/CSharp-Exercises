using System;

namespace ThisKeyword
{
    class Program
    {
        static void Main()
        {
            Student student = new Student("Gvidas");
            var studentName = student.GetName();
            Console.WriteLine(studentName);
        }
    }
}
