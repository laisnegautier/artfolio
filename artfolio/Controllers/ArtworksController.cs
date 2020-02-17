using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using artfolio.Data;
using artfolio.Models;
using artfolio.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace artfolio.Controllers
{
    [Authorize]
    public class ArtworksController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ArtworksController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Artworks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Artworks.ToListAsync());
        }

        // GET: MyArtworks
        /*public async Task<IActionResult> MyArtworks()
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);
            
            return View(await _context.Artworks.Where(a => a.Artist.User == user).ToListAsync());
        }*/

        // GET: Artworks/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var artwork = await _context.Artworks
                .FirstOrDefaultAsync(m => m.ArtworkId == id);
            if (artwork == null)
            {
                return NotFound();
            }

            return View(artwork);
        }

        // Add of tag AJAX
        [HttpPost]
        public int AddTag(int number1, int number2)
        {
            return number1 + number2;
        }

        // GET: Artworks/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Artworks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArtworkCreateViewModel viewModel)
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);
            Artist artist = _context.Artists.Single(x => x.User == user);

            Artwork artwork = new Artwork 
            {
                Title = viewModel.Artwork.Title,
                Description = viewModel.Artwork.Description,
                CreationDate = DateTime.Now,
                ReleaseDate = viewModel.Artwork.ReleaseDate,
                Privacy = viewModel.Artwork.Privacy,
                License = viewModel.Artwork.License,
                Category = viewModel.Artwork.Category,
                Artist = artist
            };

            Tag tag = new Tag { Name = viewModel.Tag.Name };

            ArtworkTag artworkTag = new ArtworkTag
            {
                Artwork = artwork,
                Tag = tag
            };

            if (ModelState.IsValid)
            {
                _context.Add(artwork);
                _context.Add(tag);
                _context.Add(artworkTag);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        // GET: Artworks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artwork = await _context.Artworks.FindAsync(id);
            if (artwork == null)
            {
                return NotFound();
            }
            return View(artwork);
        }

        // POST: Artworks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtworkId,Title,Description,CreationDate,ReleaseDate,Privacy,License")] Artwork artwork)
        {
            if (id != artwork.ArtworkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artwork);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtworkExists(artwork.ArtworkId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(artwork);
        }

        // GET: Artworks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artwork = await _context.Artworks
                .FirstOrDefaultAsync(m => m.ArtworkId == id);
            if (artwork == null)
            {
                return NotFound();
            }

            return View(artwork);
        }

        // POST: Artworks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artwork = await _context.Artworks.FindAsync(id);
            _context.Artworks.Remove(artwork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtworkExists(int id)
        {
            return _context.Artworks.Any(e => e.ArtworkId == id);
        }
    }
}
