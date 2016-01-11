using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        private static void Main()
        {
            Twitch instance = null;

            var twitch = new Twitch();

            object accessedField = GetInstanceField(typeof(Twitch), twitch, "turboUserCount");
            Console.WriteLine("Private field value = " + accessedField);
        }

        private static object GetInstanceField(Type type, object memberInstance, string fieldName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.NonPublic;

            FieldInfo field = type.GetField(fieldName, bindFlags);
            //ternary operator bellow. Iš esmės klausia ar null ar ne? 
            return field?.GetValue(memberInstance);
        }
    }
}
