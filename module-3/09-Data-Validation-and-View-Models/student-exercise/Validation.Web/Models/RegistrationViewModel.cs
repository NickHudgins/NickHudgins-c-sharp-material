using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "The FirstName is required")]
        [StringLength(20, ErrorMessage = "Must be between 5 and 20 characters", MinimumLength = 5)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "The LastName is required")]
        [StringLength(20, ErrorMessage = "Must be between 5 and 20 characters", MinimumLength = 5)]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "A Valid Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Passwords must be at least 8 characters")]
        [StringLength(20, ErrorMessage = "Must be between 8 and 20 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public int NumberOfTickets { get; set; }
    }
}