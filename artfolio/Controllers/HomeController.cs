﻿using System;
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
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {            
            return View(await _userManager.Users.ToListAsync());
        }
        
        public async Task<IActionResult> Index2()
        {
            return View(await _userManager.Users.ToListAsync());
        }

        public async Task<IActionResult> Search(string id)
        {
            if (String.IsNullOrEmpty(id)) return NotFound();

            // REQUESTS
            var artworks = from a in _context.Artworks
                           select a;
            var artists = from a in _context.Artists
                          select a;

            // QUERIES
            artworks = artworks.Where(x => x.Title.Contains(id));
            artists = artists.Where(x => x.Lastname.Contains(id));

            // SORT
            artworks = artworks
                    .Include(x => x.ArtworkTags)
                        .ThenInclude(artworkTag => artworkTag.Tag)
                    .Include(x => x.Documents)
                    .Include(x => x.Artist)
                    .OrderByDescending(x => x.ReleaseDate);

            SearchIndexViewModel viewModel = new SearchIndexViewModel
            {
                Artworks = await artworks.ToListAsync(),
                Artists = await artists.ToListAsync()
            };

            return View(viewModel);
        }

        public async Task<IActionResult> CurrentUser()
        {
            ApplicationUser myself = await _userManager.GetUserAsync(User);

            return View(myself);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
