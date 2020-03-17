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
            Artist artist = await _userManager.FindByNameAsync(userName);
            if (artist == null) return NotFound();

            return View(artist);
        }

        // TESTING PURPOSE
        public async Task<IActionResult> Follow()
        {
            return View(await _userManager.GetUserAsync(User));
        }
    }
}