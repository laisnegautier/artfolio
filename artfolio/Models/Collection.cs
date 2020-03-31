using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class Collection
    {
        public int CollectionId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        public DateTime CreationDate { get; set; }

        public virtual Artist Artist { get; set; }
        
        public virtual ICollection<Artwork> Artworks { get; set; }
    } 
}
