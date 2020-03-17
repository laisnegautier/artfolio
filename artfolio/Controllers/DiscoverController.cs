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

        public async Task<IActionResult> Index(string q, string tag, string category)
        {
            // Initial queries
            IQueryable<Artwork> artworks = _context.Artworks
                .OrderByDescending(x => x.ReleaseDate);

            IQueryable<Artist> artists = _userManager.Users
                .OrderByDescending(x => x.UserName);

            // Parameters check
            if (!String.IsNullOrEmpty(q))
            {
                artworks = artworks.Where(x => x.Title.Contains(q));
                artists = artists.Where(x => x.UserName.Contains(q));
            }

            if (!String.IsNullOrEmpty(tag))
                artworks = artworks.Where(x => x.ArtworkTags.Any(artworkTag => artworkTag.Tag.Name.Contains(tag))); 

            if (!String.IsNullOrEmpty(category)) 
                artworks = artworks.Where(x => x.Category == (Category)Enum.Parse(typeof(Category), category, true));

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

            return View(viewModel);
        }
    }
}
