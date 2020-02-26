using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using artfolioensc.Models;
using Microsoft.AspNetCore.Http;

namespace artfolioensc.ViewModels
{
    public class FeedIndexViewModel
    {
        public IEnumerable<Artwork> Artworks { get; set; }
        public IEnumerable<Artist> Following { get; set; }
    }
}
