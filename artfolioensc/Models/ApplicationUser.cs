﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace artfolioensc.Models
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