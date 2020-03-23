using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using artfolio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using artfolio.ValidationAttributes;

namespace artfolio.ViewModels
{
    // ControllerActionViewModel
    public class ArtworkPublishViewModel
    {
        public Artwork Artwork { get; set; }
        public Document Document { get; set; }
        public Tag Tags { get; set; }
        public ArtworkTag ArtworkTag { get; set; }

        [Required]
        [ArtfolioMedia]
        public IFormFile File { get; set; }


        public int CreativeCommonsId { get; set; }
        public IEnumerable<CreativeCommons> CreativeCommons { get; set; }
        //public List<Document> Documents { get; set; }
    }
}
