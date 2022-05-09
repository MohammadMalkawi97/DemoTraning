using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraning.Areas.Identity.Data
{
    public class ApplicationUser:IdentityUser
    {

        public string City { get; set; }

        public string Gender { get; set; }
    }
}
