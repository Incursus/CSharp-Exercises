using System;
namespace UserDefinedAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CoolNickName : Attribute
    {
        public string Name { get; private set; }

        public CoolNickName(string name)
        {
            Name = name;
        }
    }
}