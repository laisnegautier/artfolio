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
        public DateTime PublicationDate { get; set; }
        public Visibility Privacy { get; set; }
        [Required]
        public CreativeCommonsLicense License { get; set; }

        public Artist Artist { get; set; }
        public ArtworkCategory ArtworkCategory { get; set; }

        public IList<Document> Documents { get; set; }
        public IList<Support> Supports { get; set; }
    }

    public enum CreativeCommonsLicense
    {
        [Display(Name = "CC0")]
        CC0 = 0,
        [Display(Name = "CC BY")]
        BY = 1,
        [Display(Name = "CC BY-SA")]
        BY_SA = 2,
        [Display(Name = "CC BY-ND")]
        BY_ND = 3,
        [Display(Name = "CC BY-NC")]
        BY_NC = 4,
        [Display(Name = "CC BY-NC-SA")]
        BY_NC_SA = 5,
        [Display(Name = "CC BY-NC-ND")]
        BY_NC_ND = 6,
        [Display(Name = "Public Domain")]
        PublicDomain = 7
    }

    public enum Visibility
    {
        [Display(Name = "Do not publish now")]
        NotPublished = 0,
        Public = 1,
        Private = 2
    }
}