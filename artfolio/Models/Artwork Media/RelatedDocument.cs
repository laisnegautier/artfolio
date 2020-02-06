using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class RelatedDocument
    {
        public int RelatedDocumentId { get; set; }
        
        [Required]
        public int Position { get; set; }


        #region Foreign Keys 

        [Required]
        public Artwork Artwork { get; set; }

        [Required]
        public DocumentType DocumentType { get; set; }

        #endregion


        #region Associated elements

        #endregion
    }
}
