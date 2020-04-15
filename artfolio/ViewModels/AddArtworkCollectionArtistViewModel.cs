using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using artfolio.Models;

namespace artfolio.ViewModels
{
    public class AddArtworkCollectionArtistViewModel
    {
        [Required]
        public int CollectionId { get; set; }

        [Required]
        public int ArtworkId { get; set; }
        public string ToggleModalAddCollection { get; set; }

        public virtual IEnumerable<Artwork> Artworks { get; set; }
    }
}
