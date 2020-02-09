﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace artfolio.Models
{
    /// <summary>
    /// An artist is linked to a login
    /// </summary>
    public class Artist
    {
        public int ArtistId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string PublicLink { get; set; }
        public byte[] Photo { get; set; }
        [Required]
        public bool IsPubliclyVisible { get; set; }

        //public Identity.ApplicationUser User { get; set; }

        public ICollection<Artwork> Artworks { get; set; }
        public ICollection<Collection> Collections { get; set; }
        //public ICollection<Follower> Following { get; set; }

    }
}

