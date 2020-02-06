using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class OtherLicense
    {
        public int OtherLicenseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
