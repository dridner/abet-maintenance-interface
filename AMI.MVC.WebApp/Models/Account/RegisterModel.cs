using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AMI.MVC.WebApp.Models.Account
{
    public class RegisterModel
    {
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        [Compare("EmailAddress", ErrorMessage = "Email Addresses do not match.")]
        public string ConfirmEmailAddress { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("ConfirmPassword", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}