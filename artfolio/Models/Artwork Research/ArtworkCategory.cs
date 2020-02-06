using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class ArtworkCategory
    {
        public int ArtworkCategoryId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public byte[] Image { get; set; }


        #region Foreign Keys 

        #endregion


        #region Associated elements

        // Artworks associated with a category (writing, drawing etc...)
        public ICollection<Artwork> Artworks { get; set; }

        #endregion
    }
}
