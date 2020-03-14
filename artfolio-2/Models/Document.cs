using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace artfolio.Models
{
    /// <summary>
    /// A document is a picture or an audio file. 
    /// Depending on its category, it is saved in a specific folder with the convention: <artworkName_DocumentId>.extension
    /// </summary>
    public class Document
    {
        public int DocumentId { get; set; }

        [Display(Name = "Main document")]
        public bool IsMainDocument { get; set; }
        // 0 is the main document
        public int Position { get; set; }
        public DocumentMedia Media { get; set; }

        [DataType(DataType.Url)]
        public string FilePath { get; set; }

        public Artwork Artwork { get; set; }
    }

    public enum DocumentMedia
    {
        [Display(Name = "Picture (.jpeg or .png)")]
        Picture = 1,
        [Display(Name = "Audio (.wav, .aac or .mp3)")]
        Audio = 2,
        [Display(Name = "PDF")]
        PDF = 3
    }
}
