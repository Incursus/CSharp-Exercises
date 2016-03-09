using System;

namespace Static
{
    public static class ExtensionMethods
    {
        public static void ToConsole(this string email)
        {
            Console.WriteLine(email);
        }
    }
}
