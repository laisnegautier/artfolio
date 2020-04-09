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
        private readonly IPasswordHasher<Artist> _passwordHasher;
        private readonly Random _rnd = new Random();

        public HomeController(ApplicationDbContext context, IPasswordHasher<Artist> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public IActionResult Index()
        {
            int offset = _rnd.Next(0, _context.Artworks.Count());

            return View(_context.Artworks.Skip(offset).FirstOrDefault());
        }

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

        public IActionResult Privacy() => View();

        public IActionResult CookiePolicy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}