using System;
namespace UserDefinedAttribute
{

    public class CoolNickName : Attribute
    {
        public string _nickName;

        public CoolNickName(string _nickName)
        {
          this._nickName = "flusha";
        }

        public string GetNickName()
        {
            return _nickName;
        } 
    }
}