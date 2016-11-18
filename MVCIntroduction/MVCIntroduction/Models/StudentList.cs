using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntroduction.Models
{
    public class Team
    {
        public int Position { get; set; }
        public string HomeGround { get; set; }
        public string NickName { get; set; }
        public int Founded { get; set; }
        public string Name { get; set; }
    }
}