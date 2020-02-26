using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolioensc.Models
{
    /// <summary>
    /// A support is a comment made by another artist on an artwork
    /// </summary>
    public class Support
    {
        public int SupportId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }

        public Artwork Artwork { get; set; }
        public Artist Artist { get; set; }
    }
}
