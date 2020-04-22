using artfolio.Data;
using artfolio.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;

namespace artfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Artist> _userManager;
        private readonly IPasswordHasher<Artist> _passwordHasher;
        private readonly Random _rnd = new Random();

        public HomeController(ApplicationDbContext context, UserManager<Artist> userManager, IPasswordHasher<Artist> passwordHasher)
        {
            _context = context;
            _userManager = userManager;
            _passwordHasher = passwordHasher;
        }

        public IActionResult Index()
        {
            int offset = _rnd.Next(0, _context.Artworks.Count());

            return View(_context.Artworks.Skip(offset).FirstOrDefault());
        }

        public IActionResult Privacy() => View();

        public IActionResult CookiePolicy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        public IActionResult Seed()
        {
            // Artists
            for (int i = 0; i < 40; i++)
            {
                string id = Guid.NewGuid().ToString();
                Artist artist = new Artist
                {
                    Id = id,
                    UserName = "Joe" + id.Substring(0, 15),
                    NormalizedUserName = "JOE" + id.Substring(0, 15).ToUpper(),
                    Email = "Joe" + id.Substring(0, 15) + "@gmail.com",
                    NormalizedEmail = "JOE" + id.Substring(0, 15).ToUpper() + "@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    Lastname = "Seed",
                    Firstname = "Joe" + id.Substring(0, 6),
                    Description = id.Substring(0, 15) + "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    DateOfBirth = DateTime.Now,
                    Nationality = (Nationality)_rnd.Next(1, 200),
                    Gender = (Gender)_rnd.Next(0, 3),
                    PhotoFilePath = "Joe0" + _rnd.Next(1, 6) + ".jpg",
                    IsPubliclyVisible = true
                };

                _context.Add(artist);

                var hashedPassword = _passwordHasher.HashPassword(artist, "YourPassword");
                artist.SecurityStamp = Guid.NewGuid().ToString();
                artist.PasswordHash = hashedPassword;

                _context.SaveChanges();
            }

            return View();
        }

        public IActionResult SeedPicture()
        {
            int skipArtist;
            int skipCC;
            Artist artist;
            CreativeCommons cc; 
            Artwork artwork;
            Document document;

            // Artwork
            for (int i = 1; i < 20; i++)
            {
                skipArtist = _rnd.Next(0, 15);
                artist = _userManager.Users.OrderBy(o => o.Id).Skip(skipArtist).Take(1).First();
                skipCC = _rnd.Next(0, 6);
                cc = _context.CreativeCommons.OrderBy(o => o.CreativeCommonsId).Skip(skipCC).Take(1).First();


                int booleanRdn = _rnd.Next(0, 3);
                string supplement = "";
                string supplementSlug = "";
                if (booleanRdn == 1)
                {
                    supplement = " la nuit";
                    supplementSlug = "-la-nuit";
                }
                
                if (i == 18 || i == 19)
                {
                    artwork = new Artwork
                    {
                        Title = "PDF" + i + supplement,
                        NormalizedTitle = "pdf-" + i + supplementSlug,
                        Description = "Scelerisque tincamcorper finibus massa aliquet quis. Aenean dignissim mi vel tincidunt faucibus.",
                        CreationDate = DateTime.Now,
                        ReleaseDate = RandomDay(),
                        Privacy = true,
                        Category = Category.Writing,
                        IsDerivating = false,
                        CCLicense = cc,
                        Artist = artist
                    };

                    document = new Document
                    {
                        IsMainDocument = true,
                        Position = 0,
                        Media = DocumentMedia.PDF,
                        FilePath = "pdf" + i + ".pdf",
                        ContentType = "application/pdf",
                        Artwork = artwork
                    };

                    Tag pdf = new Tag { Name = "pdfSeed" };
                    ArtworkTag pdfArtworkTag = new ArtworkTag { Tag = pdf, Artwork = artwork };

                    _context.Tags.Add(pdf);
                    _context.ArtworkTags.Add(pdfArtworkTag);
                }
                else
                {
                    artwork = new Artwork
                    {
                        Title = "Title" + i + supplement,
                        NormalizedTitle = "titre-" + i + supplementSlug,
                        Description = "Curabitur tellus nunc, scelerisque et nunc ut, ullamcorper cursus magna. Fusce faucibus ligula vitae lobortis vestibulum. Sed scelerisque tincidunt velit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aliquam nec iaculis metus, id tincidunt purus. Sed tempor metus odio, sed tempor neque commodo sit amet. Nam malesuada aliquam justo, ullamcorper finibus massa aliquet quis. Aenean dignissim mi vel tincidunt faucibus.",
                        CreationDate = DateTime.Now,
                        ReleaseDate = RandomDay(),
                        Privacy = true,
                        Category = Category.Photography,
                        IsDerivating = false,
                        CCLicense = cc,
                        Artist = artist
                    };

                    document = new Document
                    {
                        IsMainDocument = true,
                        Position = 0,
                        Media = DocumentMedia.Picture,
                        FilePath = "photo" + i + ".jfif",
                        ContentType = "image/jpeg",
                        Artwork = artwork
                    };

                    Tag tag = new Tag { Name = "seed" };
                    ArtworkTag artworkTag = new ArtworkTag { Tag = tag, Artwork = artwork };

                    _context.Tags.Add(tag);
                    _context.ArtworkTags.Add(artworkTag);
                }

                _context.Artworks.Add(artwork);
                _context.Documents.Add(document);
                _context.SaveChanges();
            }

            return View();
        }

        private DateTime RandomDay()
        {
            DateTime start = new DateTime(1985, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_rnd.Next(range));
        }
    }
}