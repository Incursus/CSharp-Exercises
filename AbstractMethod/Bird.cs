using System;

namespace AbstractMethod
{
    public class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I'm a bird I fly and I don't like snakes.");
        }
    }
}