using System;

namespace AbstractMethod
{
    public class Snake : Animal
    {
        public override void Move()
        {
           Console.WriteLine("I'm a snake I slither.");
        }
    }
}