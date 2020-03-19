using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    /// <summary>
    /// A support is a comment made by another artist on an artwork
    /// </summary>
    public class Support
    {
        public int SupportId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Artwork Artwork { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
