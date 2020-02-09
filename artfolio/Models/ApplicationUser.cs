using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace artfolio.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Gender { get; set; }
    }

    /*public enum Gender
    {
        Male = 1,
        Female = 2
    }*/
}
