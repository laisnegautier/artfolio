using artfolio.Data;
using artfolio.Models;
using artfolio.ValidationAttributes;
using artfolio.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Slugify;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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

        [AllowAnonymous]
        public async Task<IActionResult> Index(string userName, string title)
        {
            ArtworkIndexViewModel viewModel = new ArtworkIndexViewModel
            {
                Artist = await _userManager.FindByNameAsync(userName),
                Artwork = await _context.Artworks.SingleAsync(x => x.NormalizedTitle == title)
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Support, ArtworkId")] ArtworkIndexViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Support support = new Support
                {
                    Content = viewModel.Support.Content,
                    CreationDate = DateTime.Now,
                    Artwork = await _context.Artworks.SingleAsync(x => x.ArtworkId == viewModel.ArtworkId),
                    Artist = await _userManager.GetUserAsync(User)
                };

                _context.Supports.Add(support);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
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
        public async Task<IActionResult> Publish()
        {
            IQueryable<CreativeCommons> creativeCommons = _context.CreativeCommons;

            ArtworkPublishViewModel viewModel = new ArtworkPublishViewModel
            {
                CreativeCommons = await creativeCommons.ToListAsync()
            };

            return View(viewModel);
        }

        // POST: Artworks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Publish([Bind("Artwork, Document, Tags, ArtworkTag, File, CreativeCommonsId")] ArtworkPublishViewModel viewModel)
        {
            // Reinitialisation
            IQueryable<CreativeCommons> creativeCommons = _context.CreativeCommons;

            viewModel.CreativeCommons = await creativeCommons.ToListAsync();

            if (ModelState.IsValid)
            {
                // FILE UPLOAD
                string uniqueFileName = null;
                if (viewModel.File != null)
                {
                    // Verifications content-type, mime-type, scripting etc
                    bool isPicture = FormFileExtensions.IsPicture(viewModel.File, out string errorImage);
                    bool isAudio = FormFileExtensions.IsAudio(viewModel.File, out string errorAudio);
                    bool isPdf = FormFileExtensions.IsPDF(viewModel.File, out string errorPdf);

                    string folder = null;
                    if (isPicture) folder = "artworks/picture/";
                    else if (isAudio) folder = "artworks/audio/";
                    else if (isPdf) folder = "artworks/pdf/";

                    string uploadsFolder = Path.Combine(_hostingEnv.WebRootPath, folder);
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + viewModel.File.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    try
                    {
                        viewModel.File.CopyTo(new FileStream(filePath, FileMode.Create));
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("error", $"An unexpected error occurred : + {e.Message}");
                    }

                    // Creating thumbnails for pic
                    if (isPicture)
                    {
                        string uploadsThumbnailAvatarFolder = Path.Combine(_hostingEnv.WebRootPath, "artworks/picture/thumbnails");
                        string thumbnailFilePath = Path.Combine(uploadsThumbnailAvatarFolder, uniqueFileName);

                        Image image = Image.FromStream(viewModel.File.OpenReadStream(), true, true);

                        double ratio = 200 * 1.0 / image.Width;
                        int newHeight = (int)Math.Floor(image.Height * ratio);

                        var newImage = new Bitmap(200, newHeight);

                        using var thumbnail = Graphics.FromImage(newImage);
                        thumbnail.CompositingQuality = CompositingQuality.HighSpeed;
                        thumbnail.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        thumbnail.CompositingMode = CompositingMode.SourceCopy;
                        thumbnail.DrawImage(image, 0, 0, 200, newHeight);

                        newImage.Save(thumbnailFilePath);
                    }
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
                    CCLicense = await _context.CreativeCommons.FirstAsync(x => x.CreativeCommonsId == viewModel.CreativeCommonsId),
                    Category = viewModel.Artwork.Category,
                    IsDerivating = viewModel.Artwork.IsDerivating,
                    LinkDerivating = viewModel.Artwork.LinkDerivating,
                    LicenseDerivating = viewModel.Artwork.LicenseDerivating,
                    AuthorDerivating = viewModel.Artwork.AuthorDerivating,
                    Artist = await _userManager.GetUserAsync(User)
                };

                Document documentToAdd = new Document
                {
                    Media = viewModel.Document.Media,
                    FilePath = uniqueFileName,
                    ContentType = viewModel.File.ContentType.ToLower(),
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

                // We redirect on the new artwork page then
                return RedirectToAction(nameof(Index), new { userName = _userManager.GetUserName(User), title = normalizedTitle });
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