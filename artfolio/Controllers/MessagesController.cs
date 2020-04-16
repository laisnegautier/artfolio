using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using artfolio.Models;
using artfolio.Data;
using artfolio.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace artfolio.Controllers
{
    [Authorize]
    public class MessagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Artist> _userManager;

        public MessagesController(UserManager<Artist> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string userName)
        {
            if (String.IsNullOrEmpty(userName))
            {
                return NotFound();
            }

            Artist receiver = await _userManager.FindByNameAsync(userName);
            Artist user = await _userManager.GetUserAsync(User);
            IQueryable<Message> messages =
                _context.Messages
                .Where(m => (m.Receiver == receiver && m.Sender == user) || (m.Receiver == user && m.Sender == receiver))
                .OrderBy(m => m.CreationDate);

            MessagesIndexViewModel viewModel = new MessagesIndexViewModel
            {
                Receiver = receiver,
                Messages = messages.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Messages([Bind("ReceiverId, MessageToSend")] MessagesIndexViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Message message = new Message
                {
                    Content = viewModel.MessageToSend.Content,
                    CreationDate = DateTime.Now,
                    Sender = await _userManager.GetUserAsync(User),
                    Receiver = await _userManager.FindByIdAsync(viewModel.ReceiverId)
                };

                _context.Messages.Add(message);

                await _context.SaveChangesAsync();


                Artist receiver = await _userManager.FindByIdAsync(viewModel.ReceiverId);
                Artist user = await _userManager.GetUserAsync(User);
                IQueryable<Message> messages =
                    _context.Messages
                    .Where(m => (m.Receiver == receiver && m.Sender == user) || (m.Receiver == user && m.Sender == receiver))
                    .OrderBy(m => m.CreationDate);

                MessagesIndexViewModel nviewModel = new MessagesIndexViewModel
                {
                    Receiver = receiver,
                    Messages = messages.ToList()
                };

                return PartialView("_Messages", nviewModel);
            }

            return PartialView("_Test");
        }
    }
}