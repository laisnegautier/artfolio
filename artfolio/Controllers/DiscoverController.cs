using artfolio.Data;
using artfolio.Models;
using artfolio.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace artfolio.Controllers
{
    /// <summary>
    /// Discover is publicly visible by non-members.
    /// It is the center of the website and is designed to show off latest uploaded artworks.
    /// Only released and publicly visible artworks are visible to everyone.
    /// </summary>
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

        /// <summary>
        /// The discover page is very versatile and adapt to filters (each param is a filter type)
        /// </summary>
        /// <param name="q">query research</param>
        /// <param name="tag">keyword associated to an artwork</param>
        /// <param name="category">painting, drawing etc</param>
        /// <param name="cc">Creative Commons license</param>
        /// <param name="release">latest or oldest releases first</param>
        /// <param name="following">MEMBERS ONLY : to show only artworks from artists a member follows</param>
        /// <returns>a view</returns>
        public async Task<IActionResult> Index(string q, string tag, string category, string cc, string release, string following)
        {
            // Initial queries
            IQueryable<Artwork> artworks = _context.Artworks
                .Where(x => x.Privacy == true) // is visible by everyone
                .OrderByDescending(x => x.ReleaseDate)
                .Take(30);

            IQueryable<Artist> artists = _userManager.Users
                .OrderByDescending(x => x.UserName)
                .Take(10);

            // Cumulative queries
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
                if (release == "latest")
                    artworks = artworks.OrderByDescending(x => x.ReleaseDate);
                else if (release == "oldest")
                    artworks = artworks.OrderBy(x => x.ReleaseDate);

            if (_signInManager.IsSignedIn(User) && following == "true")
            {
                Artist user = await _userManager.GetUserAsync(User);
                artworks = artworks.Where(x => x.Artist.FollowedBy.Any(followedBy => followedBy.FromArtist == user));
                artists = artists.Where(x => x.FollowedBy.Any(followedBy => followedBy.FromArtist == user));
            }

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
            ViewData["following"] = following;

            return View(viewModel);
        }
    }
}