﻿using System;
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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using Slugify;

namespace artfolio.Controllers
{
    [Authorize]
    public class ArtworkController : Controller
    {
        private readonly UserManager<Artist> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnv;

        public ArtworkController(UserManager<Artist> userManager, ApplicationDbContext context, IWebHostEnvironment hostingEnv)
        {
            _userManager = userManager;
            _context = context;
            _hostingEnv = hostingEnv;
        }

        // GET: Artworks
        public async Task<IActionResult> Index(string userName, string title)
        {
            return View(await _context.Artworks.ToListAsync());
        }

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

        // GET: Artworks/Create
        [Authorize]
        public IActionResult Publish()
        {
            return View();
        }

        // POST: Artworks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Publish(ArtworkPublishViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // FILE UPLOAD
                string uniqueFileName = null;
                if(viewModel.File != null)
                {
                    string uploadsFolder = Path.Combine(_hostingEnv.WebRootPath, "images/artworks");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + viewModel.File.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    viewModel.File.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                // SEO-friendly URL
                SlugHelper helper = new SlugHelper();
                string normalizedTitle = helper.GenerateSlug(viewModel.Artwork.Title);

                Artwork artworkToAdd = new Artwork
                {
                    Title = viewModel.Artwork.Title,
                    NormalizedTitle = normalizedTitle,
                    Description = viewModel.Artwork.Description,
                    CreationDate = DateTime.Now,
                    ReleaseDate = viewModel.Artwork.ReleaseDate,
                    Privacy = viewModel.Artwork.Privacy,
                    License = viewModel.Artwork.License,
                    Category = viewModel.Artwork.Category,
                    Artist = await _userManager.GetUserAsync(User)
                };
                
                Document documentToAdd = new Document
                {
                    IsMainDocument = viewModel.Document.IsMainDocument,
                    Media = viewModel.Document.Media,
                    FilePath = uniqueFileName,
                    Artwork = artworkToAdd
                };

                _context.Add(artworkToAdd);
                _context.Add(documentToAdd);

                // Tag and linking many-to-many
                char[] delimiterChars = { ',', '.', ';' };

                string[] tags = viewModel.Tags.Name.Split(delimiterChars);

                foreach (string tag in tags)
                {
                    Tag tagToAdd = new Tag { Name = tag };
                    ArtworkTag artworkTagToAdd = new ArtworkTag { Artwork = artworkToAdd, Tag = tagToAdd };

                    _context.Add(tagToAdd);
                    _context.Add(artworkTagToAdd);
                }
                
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
