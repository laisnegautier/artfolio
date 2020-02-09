using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class Document
    {
        public int DocumentId { get; set; }


        [Required]
        public Artwork Artwork { get; set; }

        [Required]
        public bool IsMainDocument { get; set; }

        [Required] // 0 is the main document
        public int Position { get; set; }

        [Required]
        public DocumentCategory Category { get; set; }
    }

    public enum DocumentCategory
    {
        Photography = 1,
        Painting = 2,
        Drawing = 3,
        Writing = 4,
        Audio = 5,
        SheetMusic = 6
    }
}
