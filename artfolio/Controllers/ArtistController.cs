using artfolio.Data;
using artfolio.Models;
using artfolio.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace artfolio.Controllers
{
    public class ArtistController : Controller
    {
        private readonly SignInManager<Artist> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Artist> _userManager;

        public ArtistController(SignInManager<Artist> signInManager, UserManager<Artist> userManager, ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _context = context;
            _userManager = userManager;
        }

        // Display an artist profile
        public async Task<IActionResult> Index(string userName)
        {
            if (string.IsNullOrEmpty(userName)) return NotFound();

            Artist artist = await _userManager.FindByNameAsync(userName);
            if (artist == null) return NotFound();

            // Privacy settings
            if (_signInManager.IsSignedIn(User))
            {
                Artist user = await _userManager.GetUserAsync(User);
                if (user != null && (!artist.IsPubliclyVisible && user != artist)) return NotFound();
            }
            else
            {
                if (!artist.IsPubliclyVisible) return NotFound();
            }

            ArtistIndexViewModel viewModel = new ArtistIndexViewModel
            {
                Artist = artist
            };

            // Check if the viewer is following the artist
            if (_signInManager.IsSignedIn(User))
            {
                Artist user = await _userManager.GetUserAsync(User);
                Artist toFollow = await _userManager.FindByNameAsync(userName);
                FollowRelation followRelation = await _context.FollowRelations.FirstOrDefaultAsync(x => x.FromArtistId == user.Id && x.ToArtistId == toFollow.Id);

                ViewData["isFollowing"] = followRelation != null ? true : false;
            }

            return View(viewModel);
        }

        public async Task<IActionResult> Follow(string userName)
        {
            Artist user = await _userManager.GetUserAsync(User);
            Artist toFollow = await _userManager.FindByNameAsync(userName);

            FollowRelation followRelation = new FollowRelation
            {
                FromArtistId = user.Id,
                FromArtist = user,
                ToArtistId = toFollow.Id,
                ToArtist = toFollow
            };

            FollowRelation duplicate = await _context.FollowRelations.FirstOrDefaultAsync(x => x.FromArtistId == user.Id && x.ToArtistId == toFollow.Id);
            if (duplicate == null)
            {
                _context.Add(followRelation);
                _context.SaveChanges();
            }
            else return NotFound();

            return RedirectToAction(nameof(Index), toFollow.UserName);
        }

        public async Task<IActionResult> Unfollow(string userName)
        {
            Artist user = await _userManager.GetUserAsync(User);
            Artist toFollow = await _userManager.FindByNameAsync(userName);

            FollowRelation followRelation = await _context.FollowRelations.FirstOrDefaultAsync(x => x.FromArtistId == user.Id && x.ToArtistId == toFollow.Id);
            if (followRelation != null)
            {
                _context.Remove(followRelation);
                await _context.SaveChangesAsync();
            }
            else return NotFound();

            return RedirectToAction(nameof(Index), toFollow.UserName);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCollection([Bind("Name", "Description")] Collection model)
        {
            Artist user = await _userManager.GetUserAsync(User);

            if (ModelState.IsValid)
            {
                Collection collectionToAdd = new Collection
                {
                    Name = model.Name,
                    Description = model.Description,
                    CreationDate = DateTime.Now,
                    Artist = user
                };

                _context.Add(collectionToAdd);
                await _context.SaveChangesAsync();
            }
            else return NotFound();

            return RedirectToAction(nameof(Index), user.UserName);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCollection(int id)
        {
            Artist user = await _userManager.GetUserAsync(User);
            Collection collection = await _context.Collections.FindAsync(id);

            foreach (Artwork artwork in collection.Artworks)
            {
                artwork.Collection = null;
                _context.Artworks.Update(artwork);
            }

            _context.Collections.Remove(collection);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), user.UserName);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCollection(Collection viewModel)
        {
            Artist user = await _userManager.GetUserAsync(User);
            Collection collection = await _context.Collections.FindAsync(viewModel.CollectionId);

            collection.Name = viewModel.Name;
            collection.Description = viewModel.Description;

            _context.Collections.Update(collection);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), user.UserName);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveArtworkCollection(int CollectionId, int ArtworkId)
        {
            Artist user = await _userManager.GetUserAsync(User);
            Artwork artwork = await _context.Artworks.FindAsync(ArtworkId);
            Collection collection = await _context.Collections.FindAsync(CollectionId);

            artwork.Collection = null;
            _context.Artworks.Update(artwork);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), user.UserName);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddArtworkCollection(AddArtworkCollectionArtistViewModel viewModel)
        {
            Artist user = await _userManager.GetUserAsync(User);

            if (ModelState.IsValid)
            {
                Collection collection = await _context.Collections.FindAsync(viewModel.CollectionId);
                Artwork artworkToUpdate = await _context.Artworks.FindAsync(viewModel.ArtworkId);

                artworkToUpdate.Collection = collection;

                _context.Artworks.Update(artworkToUpdate);
                _context.SaveChanges();
            }
            else return NotFound();

            return RedirectToAction(nameof(Index), user.UserName);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUserInfos([Bind("Lastname","Firstname","Description","Nationality","Gender","IsPubliclyVisible")] Artist viewModel)
        {
            Artist user = await _userManager.GetUserAsync(User);

            if (ModelState.IsValid)
            {
                user.Lastname = viewModel.Lastname;
                user.Firstname = viewModel.Firstname;
                user.Description = viewModel.Description;
                user.Nationality = viewModel.Nationality;
                user.DateOfBirth = viewModel.DateOfBirth;
                user.Gender = viewModel.Gender;
                user.IsPubliclyVisible = viewModel.IsPubliclyVisible;

                //user.DateOfBirth = viewModel.DateOfBirth;
                await _userManager.UpdateAsync(user);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index), user.UserName);
        }
    }
}