using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RegistrationAndLoginWebsite.Areas.Account.Models
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Remote(controller: "Account", action: "RemoteValidation")]
        public string email { get; set; }


        [Required]
        [StringLength(maximumLength:100)]
        public string city { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirmPassword { get; set; }

    }
}
