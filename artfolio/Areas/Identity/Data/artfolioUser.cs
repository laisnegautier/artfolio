using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace artfolio.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the artfolioUser class
    public class artfolioUser : IdentityUser
    {
        public string NameTEST { get; set; }
    }
}
