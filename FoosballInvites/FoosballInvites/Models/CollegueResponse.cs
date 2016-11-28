using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoosballInvites.Models
{
    public class CollegueResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillPlay { get; set; }
    }
}