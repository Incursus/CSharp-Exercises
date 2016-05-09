using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserDefinedAttribute
{
    class Program
    {
        //https://msdn.microsoft.com/en-us/library/mt653985.aspx
        //https://msdn.microsoft.com/en-us/library/mt653983.aspx
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintAttributeInfo();
            PrintCoolNickNameInfo(typeof(Nip));
        }

        private static void PrintCoolNickNameInfo(System.Type type)
        {
            System.Attribute[] customAttributes = System.Attribute.GetCustomAttributes(type);
            //Console.WriteLine(customAttributes);

            foreach (Attribute attribute in customAttributes)
            {
                /*if (attribute is CoolNickName)
                {*/
                    CoolNickName coolNickName;
                    Console.WriteLine(attribute.ToString());
                //}
            }
        }

        public void PrintAttributeInfo()
        {
            PrintCoolNickNameInfo(typeof(Fnatic));
            PrintCoolNickNameInfo(typeof(Nip));
        }
    }
}
