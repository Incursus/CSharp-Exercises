using System;

namespace UserDefinedAttribute
{
    class Program
    {
        //https://msdn.microsoft.com/en-us/library/mt653985.aspx
        //https://msdn.microsoft.com/en-us/library/mt653983.aspx
        static void Main()
        {
            PrintCoolNickNameInfo(typeof(Fnatic));
            PrintCoolNickNameInfo(typeof(Nip));
        }

        private static void PrintCoolNickNameInfo(Type type)
        {
            Attribute[] customAttributes = Attribute.GetCustomAttributes(type);

            foreach (Attribute attribute in customAttributes)
            {
                var coolNickName = attribute as CoolNickName;
                if (coolNickName != null)
                {
                    Console.WriteLine($"{coolNickName.Name} -- {type.Name}");
                }
            }
        }
    }
}
