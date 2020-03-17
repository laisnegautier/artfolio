using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class ArtworkTag
    {
        public int ArtworkId { get; set; }
        public virtual Artwork Artwork { get; set; }

        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
