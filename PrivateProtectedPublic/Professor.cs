using System;

namespace PrivateProtectedPublic
{
    public class Professor : Person
    {
        private int monthlySalary = 330;

        public void PrintSalary()
        {
            Console.WriteLine("I am a professor of philosophy and make " + monthlySalary + " EUR a month.");
        }
    }
}
