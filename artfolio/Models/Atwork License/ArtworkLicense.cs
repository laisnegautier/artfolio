using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class ArtworkLicense
    {
        public int ArtworkLicenseId { get; set; }

        [Required]
        public Artwork Artwork { get; set; }
        public CreativeCommonsLicense CreativeCommonsLicense { get; set; }
        public OtherLicense OtherLicense { get; set; }
    }
}
