﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using artfolio.Data;

namespace artfolio.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200401192916_RemoveTeritorial")]
    partial class RemoveTeritorial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("artfolio.Models.Artist", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsPubliclyVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Nationality")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("artfolio.Models.Artwork", b =>
                {
                    b.Property<int>("ArtworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorDerivating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CCLicenseCreativeCommonsId")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int?>("CollectionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDerivating")
                        .HasColumnType("bit");

                    b.Property<string>("LicenseDerivating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkDerivating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Privacy")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtworkId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("CCLicenseCreativeCommonsId");

                    b.HasIndex("CollectionId");

                    b.ToTable("Artworks");
                });

            modelBuilder.Entity("artfolio.Models.ArtworkTag", b =>
                {
                    b.Property<int>("ArtworkId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ArtworkId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ArtworkTags");
                });

            modelBuilder.Entity("artfolio.Models.Collection", b =>
                {
                    b.Property<int>("CollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CollectionId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("artfolio.Models.CreativeCommons", b =>
                {
                    b.Property<int>("CreativeCommonsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BY")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalCodeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseDeedUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NC")
                        .HasColumnType("bit");

                    b.Property<bool>("ND")
                        .HasColumnType("bit");

                    b.Property<bool>("SA")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Zero")
                        .HasColumnType("bit");

                    b.HasKey("CreativeCommonsId");

                    b.ToTable("CreativeCommons");

                    b.HasData(
                        new
                        {
                            CreativeCommonsId = 1,
                            Acronym = "by",
                            BY = true,
                            Description = "This license lets others distribute, remix, tweak, and build upon your work, even commercially, as long as they credit you for the original creation. ",
                            LegalCodeUrl = "https://creativecommons.org/licenses/by/4.0/legalcode",
                            LicenseDeedUrl = "https://creativecommons.org/licenses/by/4.0",
                            NC = false,
                            ND = false,
                            SA = false,
                            Title = "Attribution",
                            Zero = false
                        },
                        new
                        {
                            CreativeCommonsId = 2,
                            Acronym = "by-sa",
                            BY = true,
                            Description = "This license lets others remix, tweak, and build upon your work even for commercial purposes, as long as they credit you and license their new creations under the identical terms.",
                            LegalCodeUrl = "https://creativecommons.org/licenses/by-sa/4.0/legalcode",
                            LicenseDeedUrl = "https://creativecommons.org/licenses/by-sa/4.0",
                            NC = false,
                            ND = false,
                            SA = true,
                            Title = "Attribution-ShareAlike",
                            Zero = false
                        },
                        new
                        {
                            CreativeCommonsId = 3,
                            Acronym = "by-nd",
                            BY = true,
                            Description = "This license lets others reuse the work for any purpose, including commercially; however, it cannot be shared with others in adapted form, and credit must be provided to you.",
                            LegalCodeUrl = "https://creativecommons.org/licenses/by-nd/4.0/legalcode",
                            LicenseDeedUrl = "https://creativecommons.org/licenses/by-nd/4.0",
                            NC = false,
                            ND = true,
                            SA = false,
                            Title = "Attribution-NoDerivs",
                            Zero = false
                        },
                        new
                        {
                            CreativeCommonsId = 4,
                            Acronym = "by-nc",
                            BY = true,
                            Description = "This license lets others remix, tweak, and build upon your work non-commercially, and although their new works must also acknowledge you and be non-commercial, they don’t have to license their derivative works on the same terms.",
                            LegalCodeUrl = "https://creativecommons.org/licenses/by-nc/4.0/legalcode",
                            LicenseDeedUrl = "https://creativecommons.org/licenses/by-nc/4.0",
                            NC = true,
                            ND = false,
                            SA = false,
                            Title = "Attribution-NonCommercial",
                            Zero = false
                        },
                        new
                        {
                            CreativeCommonsId = 5,
                            Acronym = "by-nc-sa",
                            BY = true,
                            Description = "This license lets others remix, tweak, and build upon your work non-commercially, as long as they credit you and license their new creations under the identical terms.",
                            LegalCodeUrl = "https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode",
                            LicenseDeedUrl = "https://creativecommons.org/licenses/by-nc-sa/4.0",
                            NC = true,
                            ND = false,
                            SA = true,
                            Title = "Attribution-NonCommercial-ShareAlike",
                            Zero = false
                        },
                        new
                        {
                            CreativeCommonsId = 6,
                            Acronym = "by-nc-nd",
                            BY = true,
                            Description = "This license is the most restrictive of our six main licenses, only allowing others to download your works and share them with others as long as they credit you, but they can’t change them in any way or use them commercially.",
                            LegalCodeUrl = "https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode",
                            LicenseDeedUrl = "https://creativecommons.org/licenses/by-nc-nd/4.0",
                            NC = true,
                            ND = true,
                            SA = false,
                            Title = "Attribution-NonCommercial-NoDerivs",
                            Zero = false
                        },
                        new
                        {
                            CreativeCommonsId = 7,
                            Acronym = "cc-zero",
                            BY = false,
                            Description = "Use this universal tool if you are a holder of copyright or database rights, and you wish to waive all your interests that may exist in your work worldwide. Because copyright laws differ around the world, you may use this tool even though you may not have copyright in your jurisdiction, but want to be sure to eliminate any copyrights you may have in other jurisdictions.",
                            LegalCodeUrl = "https://creativecommons.org/publicdomain/zero/1.0/legalcode",
                            LicenseDeedUrl = "https://creativecommons.org/publicdomain/zero/1.0/",
                            NC = false,
                            ND = false,
                            SA = false,
                            Title = "CC0",
                            Zero = true
                        });
                });

            modelBuilder.Entity("artfolio.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArtworkId")
                        .HasColumnType("int");

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMainDocument")
                        .HasColumnType("bit");

                    b.Property<int>("Media")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("DocumentId");

                    b.HasIndex("ArtworkId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("artfolio.Models.FollowRelation", b =>
                {
                    b.Property<string>("FromArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ToArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FromArtistId", "ToArtistId");

                    b.HasIndex("ToArtistId");

                    b.ToTable("FollowRelations");
                });

            modelBuilder.Entity("artfolio.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("ReceiverId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SenderId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MessageId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("artfolio.Models.Report", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ArtworkId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReportId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ArtworkId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("artfolio.Models.Support", b =>
                {
                    b.Property<int>("SupportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ArtworkId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SupportId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ArtworkId");

                    b.ToTable("Supports");
                });

            modelBuilder.Entity("artfolio.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("artfolio.Models.Artist", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("artfolio.Models.Artist", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("artfolio.Models.Artist", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("artfolio.Models.Artist", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("artfolio.Models.Artwork", b =>
                {
                    b.HasOne("artfolio.Models.Artist", "Artist")
                        .WithMany("Artworks")
                        .HasForeignKey("ArtistId");

                    b.HasOne("artfolio.Models.CreativeCommons", "CCLicense")
                        .WithMany()
                        .HasForeignKey("CCLicenseCreativeCommonsId");

                    b.HasOne("artfolio.Models.Collection", "Collection")
                        .WithMany("Artworks")
                        .HasForeignKey("CollectionId");
                });

            modelBuilder.Entity("artfolio.Models.ArtworkTag", b =>
                {
                    b.HasOne("artfolio.Models.Artwork", "Artwork")
                        .WithMany("ArtworkTags")
                        .HasForeignKey("ArtworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("artfolio.Models.Tag", "Tag")
                        .WithMany("ArtworkTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("artfolio.Models.Collection", b =>
                {
                    b.HasOne("artfolio.Models.Artist", "Artist")
                        .WithMany("Collections")
                        .HasForeignKey("ArtistId");
                });

            modelBuilder.Entity("artfolio.Models.Document", b =>
                {
                    b.HasOne("artfolio.Models.Artwork", "Artwork")
                        .WithMany("Documents")
                        .HasForeignKey("ArtworkId");
                });

            modelBuilder.Entity("artfolio.Models.FollowRelation", b =>
                {
                    b.HasOne("artfolio.Models.Artist", "FromArtist")
                        .WithMany("Following")
                        .HasForeignKey("FromArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("artfolio.Models.Artist", "ToArtist")
                        .WithMany("FollowedBy")
                        .HasForeignKey("ToArtistId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("artfolio.Models.Message", b =>
                {
                    b.HasOne("artfolio.Models.Artist", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId");

                    b.HasOne("artfolio.Models.Artist", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");
                });

            modelBuilder.Entity("artfolio.Models.Report", b =>
                {
                    b.HasOne("artfolio.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.HasOne("artfolio.Models.Artwork", "Artwork")
                        .WithMany()
                        .HasForeignKey("ArtworkId");
                });

            modelBuilder.Entity("artfolio.Models.Support", b =>
                {
                    b.HasOne("artfolio.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.HasOne("artfolio.Models.Artwork", "Artwork")
                        .WithMany("Supports")
                        .HasForeignKey("ArtworkId");
                });
#pragma warning restore 612, 618
        }
    }
}
