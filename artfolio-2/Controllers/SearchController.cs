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
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string q, string category, string tag)
        {
            if (String.IsNullOrEmpty(q)) return NotFound();

            // REQUESTS
            var artworks = from a in _context.Artworks
                           select a;
            var artists = from a in _context.Artists
                          select a;

            // QUERIES
            artworks = artworks.Where(x => x.Title.Contains(q));
            artists = artists.Include(x => x.User).Where(x => x.User.Email.Contains(q));


            if (!String.IsNullOrEmpty(tag))
            {
                tag = tag.ToLower();
                artworks = artworks
                    .Include(x => x.ArtworkTags)
                        .ThenInclude(artworkTag => artworkTag.Tag)
                    .Where(x => x.ArtworkTags.Any(artworkTag => artworkTag.Tag.Name.Contains(tag)));
            }

            // Sort: category
            if (!String.IsNullOrEmpty(category)) category = category.ToLower();
            switch (category)
            {
                case "photography":
                    ViewData["selection"] = "photography";
                    artworks = artworks.Where(x => x.Category == Category.Photography);
                    break;
                case "drawing":
                    ViewData["selection"] = "drawing";
                    artworks = artworks.Where(x => x.Category == Category.Drawing);
                    break;
                case "painting":
                    ViewData["selection"] = "painting";
                    artworks = artworks.Where(x => x.Category == Category.Painting);
                    break;
                case "writing":
                    ViewData["selection"] = "writing";
                    artworks = artworks.Where(x => x.Category == Category.Writing);
                    break;
                case "audio":
                    ViewData["selection"] = "audio";
                    artworks = artworks.Where(x => x.Category == Category.Audio);
                    break;
                case "sheetmusic":
                    ViewData["selection"] = "sheetmusic";
                    artworks = artworks.Where(x => x.Category == Category.SheetMusic);
                    break;
                default:
                    ViewData["selection"] = "";
                    break;
            }

            artworks = artworks
                    .Include(x => x.ArtworkTags)
                        .ThenInclude(artworkTag => artworkTag.Tag)
                    .Include(x => x.Documents)
                    .Include(x => x.Artist)
                    .OrderByDescending(x => x.ReleaseDate);

            artists = artists.Include(x => x.User);

            SearchIndexViewModel viewModel = new SearchIndexViewModel
            {
                Artworks = await artworks.ToListAsync(),
                Artists = await artists.ToListAsync()
            };

            ViewData["q"] = q;
            ViewData["tag"] = tag;
            ViewData["category"] = category;

            return View(viewModel);
        }
    }
}
