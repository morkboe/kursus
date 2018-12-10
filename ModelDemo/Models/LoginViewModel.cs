using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ModelDemo.Models
{
    public class LoginViewModel
    {
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Fejl i længde af streng")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool Remember { get; set; }
    }
}