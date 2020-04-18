using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace artfolio.ViewModels
{
    public class RemoveArtworkCollectionViewModel
    {
        public int CollectionId { get; set; }
        public int ArtworkId { get; set; }
        public string ToggleModalRemoveCollection { get; set; }
    }
}
