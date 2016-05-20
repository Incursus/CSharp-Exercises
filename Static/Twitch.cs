using System;

namespace Static
{
    public class Twitch
    {
        public static void GoTurbo(string email)
        {
            Console.WriteLine($"static email: {email}");
        }

        /*If the class was static I could not have this method. 
        Static class can only have static members. 
        But a non-static class can have have both static and non-static members*/
        public void GoTurboNonStatic(string email)
        {
            Console.WriteLine($"Non static email: {email}");
        }
    }
}
