using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraning.Models.ViewModels
{
    public class RegesturViwModel
    {
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress]
        [Display(Name = "EmailAddress Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Enter Passowrd")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm")]
        [Compare("Password", ErrorMessage = "Miss match")]
        [Display(Name = "Confirm passowrd")]
        [DataType(DataType.Password)]
        public string confirnPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }
    }
}
