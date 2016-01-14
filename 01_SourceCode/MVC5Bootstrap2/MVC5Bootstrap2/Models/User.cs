using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Bootstrap2.Models
{
    public class User
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string state { get; set; }

    }
}