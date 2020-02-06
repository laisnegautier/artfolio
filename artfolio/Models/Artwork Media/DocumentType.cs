using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class DocumentType
    {
        public int DocumentTypeId { get; set; }

        [Required]
        public string Type { get; set; }
        public string Media { get; set; }


        #region Foreign Keys 

        #endregion


        #region Associated elements

        public ICollection<RelatedDocument> RelatedDocuments { get; set; }

        #endregion
    }
}
