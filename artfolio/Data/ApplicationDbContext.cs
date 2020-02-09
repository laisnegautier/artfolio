using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using artfolio.Models;

namespace artfolio.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }

        public DbSet<Document> Documents { get; set; }

        public DbSet<ArtworkTag> ArtworkTags { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<ArtfolioStyleSheet> ArtfolioStyleSheets { get; set; }

        public DbSet<ArtworkCollection> ArtworkCollections { get; set; }
        public DbSet<Collection> Collections { get; set; }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Report> Reports { get; set; }

        public DbSet<Follower> Followers { get; set; }
        public DbSet<Support> Supports { get; set; }
    }
}
