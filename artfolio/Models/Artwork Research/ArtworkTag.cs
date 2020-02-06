using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class ArtworkTag
    {
        public int ArtworkTagId { get; set; }


        #region Foreign Keys 

        [Required]
        public Artwork Artwork { get; set; }
        [Required]
        public Tag Tag { get; set; }

        #endregion


        #region Associated elements

        #endregion
    }
}
