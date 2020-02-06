using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    /// <summary>
    /// All the 6 CC Licenses currently available.
    /// More to come with the official API
    /// </summary>
    public class CreativeCommonsLicense
    {
        public int CreativeCommonsLicenseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Version { get; set; }
        public bool IsDeprecated { get; set; }
        public string OfficialLink { get; set; }
        public byte[] Logo { get; set; }

    }
}
