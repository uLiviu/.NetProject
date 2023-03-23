using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nightClub.Web.Models
{
    public class UserLogin
    {
        [Required]
        [Display(Name = "User or Email")]
        public string Credential { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}