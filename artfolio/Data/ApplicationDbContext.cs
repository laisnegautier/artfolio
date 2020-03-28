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

            #region seed
            // SEED
            modelBuilder.Entity<CreativeCommons>().HasData(
                new CreativeCommons { 
                    CreativeCommonsId = 1,
                    Title  = "Attribution",
                    Acronym = "by",
                    Description = "This license lets others distribute, remix, tweak, and build upon your work, even commercially, as long as they credit you for the original creation. ",
                    LicenseDeedUrl = "https://creativecommons.org/licenses/by/4.0",
                    LegalCodeUrl = "https://creativecommons.org/licenses/by/4.0/legalcode",
                    BY = true,
                    SA = false,
                    NC = false,
                    ND = false,
                    Zero = false
                },
                new CreativeCommons
                {
                    CreativeCommonsId = 2,
                    Title = "Attribution-ShareAlike",
                    Acronym = "by-sa",
                    Description = "This license lets others remix, tweak, and build upon your work even for commercial purposes, as long as they credit you and license their new creations under the identical terms.",
                    LicenseDeedUrl = "https://creativecommons.org/licenses/by-sa/4.0",
                    LegalCodeUrl = "https://creativecommons.org/licenses/by-sa/4.0/legalcode",
                    BY = true,
                    SA = true,
                    NC = false,
                    ND = false,
                    Zero = false
                },
                new CreativeCommons
                {
                    CreativeCommonsId = 3,
                    Title = "Attribution-NoDerivs",
                    Acronym = "by-nd",
                    Description = "This license lets others reuse the work for any purpose, including commercially; however, it cannot be shared with others in adapted form, and credit must be provided to you.",
                    LicenseDeedUrl = "https://creativecommons.org/licenses/by-nd/4.0",
                    LegalCodeUrl = "https://creativecommons.org/licenses/by-nd/4.0/legalcode",
                    BY = true,
                    SA = false,
                    NC = false,
                    ND = true,
                    Zero = false
                },
                new CreativeCommons
                {
                    CreativeCommonsId = 4,
                    Title = "Attribution-NonCommercial",
                    Acronym = "by-nc",
                    Description = "This license lets others remix, tweak, and build upon your work non-commercially, and although their new works must also acknowledge you and be non-commercial, they don’t have to license their derivative works on the same terms.",
                    LicenseDeedUrl = "https://creativecommons.org/licenses/by-nc/4.0",
                    LegalCodeUrl = "https://creativecommons.org/licenses/by-nc/4.0/legalcode",
                    BY = true,
                    SA = false,
                    NC = true,
                    ND = false,
                    Zero = false
                },
                new CreativeCommons
                {
                    CreativeCommonsId = 5,
                    Title = "Attribution-NonCommercial-ShareAlike",
                    Acronym = "by-nc-sa",
                    Description = "This license lets others remix, tweak, and build upon your work non-commercially, as long as they credit you and license their new creations under the identical terms.",
                    LicenseDeedUrl = "https://creativecommons.org/licenses/by-nc-sa/4.0",
                    LegalCodeUrl = "https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode",
                    BY = true,
                    SA = true,
                    NC = true,
                    ND = false,
                    Zero = false
                },
                new CreativeCommons
                {
                    CreativeCommonsId = 6,
                    Title = "Attribution-NonCommercial-NoDerivs",
                    Acronym = "by-nc-nd",
                    Description = "This license is the most restrictive of our six main licenses, only allowing others to download your works and share them with others as long as they credit you, but they can’t change them in any way or use them commercially.",
                    LicenseDeedUrl = "https://creativecommons.org/licenses/by-nc-nd/4.0",
                    LegalCodeUrl = "https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode",
                    BY = true,
                    SA = false,
                    NC = true,
                    ND = true,
                    Zero = false
                },
                new CreativeCommons
                {
                    CreativeCommonsId = 7,
                    Title = "CC0",
                    Acronym = "cc-zero",
                    Description = "Use this universal tool if you are a holder of copyright or database rights, and you wish to waive all your interests that may exist in your work worldwide. Because copyright laws differ around the world, you may use this tool even though you may not have copyright in your jurisdiction, but want to be sure to eliminate any copyrights you may have in other jurisdictions.",
                    LicenseDeedUrl = "https://creativecommons.org/publicdomain/zero/1.0/",
                    LegalCodeUrl = "https://creativecommons.org/publicdomain/zero/1.0/legalcode",
                    BY = false,
                    SA = false,
                    NC = false,
                    ND = false,
                    Zero = true
                });
            #endregion

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

        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<CreativeCommons> CreativeCommons { get; set; }
        public DbSet<Document> Documents { get; set; }

        public DbSet<ArtworkTag> ArtworkTags { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<Collection> Collections { get; set; }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Report> Reports { get; set; }

        public DbSet<FollowRelation> FollowRelations { get; set; }
        public DbSet<Support> Supports { get; set; }
    }
}
