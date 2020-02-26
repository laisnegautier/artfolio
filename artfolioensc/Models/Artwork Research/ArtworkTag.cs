using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolioensc.Models
{
    public class ArtworkTag
    {
        public int ArtworkTagId { get; set; }

        [Required]
        public Artwork Artwork { get; set; }
        [Required]
        public Tag Tag { get; set; }
    }
}
