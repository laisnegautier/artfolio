using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using artfolio.Models;

namespace artfolio.ViewModels
{
    public class DiscoverIndexViewModel
    {
        public IEnumerable<Artwork> Artworks { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
    }
}
