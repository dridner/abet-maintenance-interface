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
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Confirm Email Address")]
        [Compare("EmailAddress", ErrorMessage = "Email Addresses do not match.")]
        public string ConfirmEmailAddress { get; set; }

        [Required]
        [Display(Name = "Enter Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("ConfirmPassword", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}