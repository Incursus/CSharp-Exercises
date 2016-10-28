using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoosballInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Įvesk vardą")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Parašyk, ar žaisi")]
        public bool? WillAttend { get; set; }
    }
}