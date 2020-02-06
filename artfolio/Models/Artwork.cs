using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class Artwork
    {
        public int ArtworkId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }

        public Artist Artist { get; set; }
        //public ArtworkLicense ArtworkLicense { get; set; }
        public ArtworkCategory ArtworkCategory { get; set; }

        public IList<Document> Documents { get; set; }
        public IList<RelatedDocument> RelatedDocuments { get; set; }
        public IList<Support> Supports { get; set; }

    }
}