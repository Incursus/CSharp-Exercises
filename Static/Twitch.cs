using System;

namespace Static
{
    public class Twitch
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public static void GoTurbo(string email)
        {
            Console.WriteLine("My email is bobross@twitch.com");
            //Cannot go into properties cause this is a static method.
        }

        public void GoTurboNonStatic(string email)
        {
            Console.WriteLine("My email is NOT STATIC :(");
            Name = "Redukas";
            Password = "passwooord";
        }
    }
}
