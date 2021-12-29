using System;
using System.ComponentModel.DataAnnotations;

namespace Identity_Security.Models
{
    public class SignupViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address is missing or Invalid")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password, ErrorMessage = "Incorrect or missing Password")]
        public string Password { get; set; }

    }
}