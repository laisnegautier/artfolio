using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using artfolio.Models;
using Microsoft.AspNetCore.Http;

namespace artfolio.ViewModels
{
    // ControllerActionViewModel
    public class ArtworkCreateViewModel
    {
        public Artwork Artwork { get; set; }
        public Document Document { get; set; }
        public Tag Tags { get; set; }
        public ArtworkTag ArtworkTag { get; set; }
        [Required]
        public IFormFile File { get; set; }
        //public List<Document> Documents { get; set; }
    }
}
