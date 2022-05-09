using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraning.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "enter Email Address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Passowrd { get; set; }
        public bool RememberMe { get; set; }
    }
}
