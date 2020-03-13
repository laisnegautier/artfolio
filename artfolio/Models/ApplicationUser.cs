using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace artfolio.Models
{
    public class ApplicationUser : IdentityUser
    {
        //[DataType(DataType.DateTime)]
        //public DateTime Creation { get; set; }

        public Artist Artist { get; set; }
    }
}
