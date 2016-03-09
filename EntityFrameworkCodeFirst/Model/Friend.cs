using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirst
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}