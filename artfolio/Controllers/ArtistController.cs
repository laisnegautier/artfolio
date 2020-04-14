using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using artfolio.Data;
using artfolio.Models;
using artfolio.ViewModels;
using Microsoft.EntityFrameworkCore;

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

            ArtistIndexViewModel viewModel = new ArtistIndexViewModel
            {
                Artist = artist
            };

            // Check if the viewer is following the artist
            if(_signInManager.IsSignedIn(User))
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
        public async Task<IActionResult> CreateCollection([Bind("Name","Description")] Collection model)
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

            return RedirectToAction(nameof(Index), user.UserName);
        }
    }
}