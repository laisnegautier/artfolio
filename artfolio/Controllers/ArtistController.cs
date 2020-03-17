using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using artfolio.Data;
using artfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace artfolio.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Artist> _userManager;

        public ArtistController(UserManager<Artist> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        // Display an artist profile
        public async Task<IActionResult> Index(string userName)
        {
            Artist artist = await _userManager.Users
                .Where(x => x.UserName == userName)
                .FirstOrDefaultAsync();

            if (artist == null) return NotFound();

            return View(artist);
        }


        public async Task<IActionResult> Follow()
        {
            Artist user = await _userManager.GetUserAsync(User);
            Artist artist = await _userManager.Users
                .Where(u => u.Id == user.Id)
                .Include(x => x.Following)
                .Include(x => x.FollowedBy)
                .FirstOrDefaultAsync();

            return View(artist);
        }
    }
}