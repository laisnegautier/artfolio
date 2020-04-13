using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using artfolio.Models;
using artfolio.ViewModels;
using artfolio.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace artfolio.Controllers
{
    public class DiscoverController : Controller
    {
        private readonly SignInManager<Artist> _signInManager;
        private readonly UserManager<Artist> _userManager;
        private readonly ApplicationDbContext _context;

        public DiscoverController(SignInManager<Artist> signInManager, UserManager<Artist> userManager, ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index(string q, string tag, string category, string cc, string release)
        {
            // Initial queries
            IQueryable<Artwork> artworks = _context.Artworks
                .OrderByDescending(x => x.ReleaseDate)
                .Take(30);

            IQueryable<Artist> artists = _userManager.Users
                .OrderByDescending(x => x.UserName)
                .Take(10);

            // Parameters check
            if (!string.IsNullOrEmpty(q))
            {
                artworks = artworks.Where(x => x.Title.Contains(q));
                artists = artists.Where(x => x.UserName.Contains(q));
            }

            if (!string.IsNullOrEmpty(tag))
                artworks = artworks.Where(x => x.ArtworkTags.Any(artworkTag => artworkTag.Tag.Name.Contains(tag))); 

            if (!string.IsNullOrEmpty(category)) 
                artworks = artworks.Where(x => x.Category == (Category)Enum.Parse(typeof(Category), category, true));

            if (!string.IsNullOrEmpty(cc))
                artworks = artworks.Where(x => x.CCLicense.Acronym == cc);

            if (!string.IsNullOrEmpty(release))
                if(release == "latest")
                    artworks = artworks.OrderByDescending(x => x.ReleaseDate);
                else if(release == "oldest")
                    artworks = artworks.OrderBy(x => x.ReleaseDate);

            // Get rid of himself if connected
            if (_signInManager.IsSignedIn(User))
                artists = artists.Where(x => x.Id != _userManager.GetUserId(User));

            // Adding to view model
            SearchIndexViewModel viewModel = new SearchIndexViewModel
            {
                Artworks = await artworks.ToListAsync(),
                Artists = await artists.ToListAsync()
            };

            // Sending data to the view
            ViewData["q"] = q;
            ViewData["tag"] = tag;
            ViewData["category"] = category;
            ViewData["cc"] = cc;
            ViewData["release"] = release;

            return View(viewModel);
        }
    }
}
