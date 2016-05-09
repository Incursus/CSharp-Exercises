using System;
namespace UserDefinedAttribute
{

    public class CoolNickName : Attribute
    {
        public string _nickName;

        public CoolNickName(string _nickName)
        {
          this._nickName = "summitoneegg";
        }

        public string GetNickName()
        {
            return _nickName;
        } 
    }
}