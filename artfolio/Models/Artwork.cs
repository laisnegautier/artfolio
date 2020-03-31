using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace artfolio.Models
{
    public class Artwork
    {
        public int ArtworkId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        public string NormalizedTitle { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string TerritorialJuridiction { get; set; }

        [Required]
        public bool Privacy { get; set; }
        
        [Required]
        public Category Category { get; set; }

        [Required]
        public bool IsDerivating { get; set; }

        public string LinkDerivating { get; set; }

        public string LicenseDerivating { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual ICollection<ArtworkTag> ArtworkTags { get; set; }
        public virtual IList<Document> Documents { get; set; }
        public virtual IList<Support> Supports { get; set; }
        public virtual Collection Collection { get; set; }
        public virtual CreativeCommons CCLicense { get; set; }
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

    public enum Category
    {
        [Display(Name = "Painting")]
        Painting = 1,
        [Display(Name = "Photography")]
        Photography = 2,
        [Display(Name = "Drawing")]
        Drawing = 3,
        [Display(Name = "Writing")]
        Writing = 4,
        [Display(Name = "Sheet music")]
        SheetMusic = 5,
        [Display(Name = "Audio")]
        Audio = 6
    }
}