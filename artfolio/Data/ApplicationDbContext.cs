using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using artfolio.Models;

namespace artfolio.Data
{
    public class ApplicationDbContext : IdentityDbContext<Artist>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Necessary to have uniqueness of routing for an artist
            //modelBuilder.Entity<Artist>()
            //    .HasIndex(p => new { p.Id, p.PublicLink })
            //    .IsUnique();
            
            // MANY-TO-MANY Artwork and Tag
            modelBuilder.Entity<ArtworkTag>()
                .HasKey(x => new { x.ArtworkId, x.TagId });

            modelBuilder.Entity<ArtworkTag>()
                .HasOne(x => x.Artwork)
                .WithMany(y => y.ArtworkTags)
                .HasForeignKey(y => y.ArtworkId);

            modelBuilder.Entity<ArtworkTag>()
                .HasOne(bc => bc.Tag)
                .WithMany(c => c.ArtworkTags)
                .HasForeignKey(bc => bc.TagId);



            modelBuilder.Entity<FollowRelation>()
                .HasKey(x => new { x.FromArtistId, x.ToArtistId });

            modelBuilder.Entity<FollowRelation>()
                .HasOne(x => x.ToArtist)
                .WithMany(y => y.FollowedBy)
                .HasForeignKey(x => x.ToArtistId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FollowRelation>()
                .HasOne(y => y.FromArtist)
                .WithMany(x => x.Following)
                .HasForeignKey(x => x.FromArtistId);
        }

        //public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }

        public DbSet<Document> Documents { get; set; }

        public DbSet<ArtworkTag> ArtworkTags { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<ArtfolioStyleSheet> ArtfolioStyleSheets { get; set; }

        public DbSet<ArtworkCollection> ArtworkCollections { get; set; }
        public DbSet<Collection> Collections { get; set; }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Report> Reports { get; set; }

        public DbSet<FollowRelation> FollowRelations { get; set; }
        public DbSet<Support> Supports { get; set; }
    }
}
