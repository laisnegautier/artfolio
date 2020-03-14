using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class ArtworkCollection
    {
        public int ArtworkCollectionId { get; set; }
        public bool IsMasterpiece { get; set; }

        public Artwork Artwork { get; set; }
        public Collection Collection { get; set; }
    }
}
