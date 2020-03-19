using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using artfolio.Models;

namespace artfolio.ViewModels
{
    public class ArtworkIndexViewModel
    {
        // Global display
        public Artist Artist { get; set; }
        public Artwork Artwork { get; set; }

        // Send support form
        public int ArtworkId { get; set; }
        public Support Support { get; set; }
    }
}
