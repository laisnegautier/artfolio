using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        [Required]
        public string Name { get; set; }


        #region Foreign Keys 

        #endregion


        #region Associated elements

        public ICollection<ArtworkTag> ArtworkTags { get; set; }

        #endregion
    }
}
