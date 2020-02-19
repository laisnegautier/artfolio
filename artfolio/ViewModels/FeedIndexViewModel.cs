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
    public class FeedIndexViewModel
    {
        public IEnumerable<Artwork> Artworks { get; set; }
        public IEnumerable<Artist> Following { get; set; }
    }
}
