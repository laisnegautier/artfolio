using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using artfolioensc.Models;
using artfolioensc.Data;
using artfolioensc.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace artfolioensc.Controllers
{
    /// <summary>
    /// Discover allows member and non-member to see the last artwork trend
    /// </summary>
    public class DiscoverController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public DiscoverController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Discover
        public async Task<IActionResult> Index(string search, string category)
        {
            var artworks = from a in _context.Artworks
                            select a;
            
            // SEARCH
            if (!String.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                artworks = artworks.Where(x => x.Title.Contains(search));
            }

            // CATEGORY
            if (!String.IsNullOrEmpty(category)) category = category.ToLower();
            switch (category)
            {
                case "photography":
                    artworks = artworks.Where(x => x.Category == Category.Photography);
                    break;
                case "drawing":
                    artworks = artworks.Where(x => x.Category == Category.Drawing);
                    break;
                case "painting":
                    artworks = artworks.Where(x => x.Category == Category.Painting);
                    break;
                case "writing":
                    artworks = artworks.Where(x => x.Category == Category.Writing);
                    break;
                case "audio":
                    artworks = artworks.Where(x => x.Category == Category.Audio);
                    break;
                case "sheetmusic":
                    artworks = artworks.Where(x => x.Category == Category.SheetMusic);
                    break;
                default:
                    break;
            }

            artworks = artworks
                    .Include(x => x.ArtworkTags)
                        .ThenInclude(artworkTag => artworkTag.Tag)
                    .Include(x => x.Documents);

            // AsNoTracking means no caching. Useful for read-only queries.
            return View(await artworks.AsNoTracking().ToListAsync());
        }
    }
}