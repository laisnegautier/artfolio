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

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        
        public Artist Artist { get; set; }
    }
}
