using artfolio.Data;
using artfolio.Models;
using artfolio.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<IActionResult> Index()
        {
            Artist user = await _userManager.GetUserAsync(User);

            // we get the last 10 conversations where user tried to send a message at least once
            IQueryable<IGrouping<Artist, Message>> conversations = _context.Messages
                .GroupBy(c => c.Sender)
                .Take(10);

            IQueryable<Artist> artists = _userManager.Users
                .OrderByDescending(x => x.UserName)
                .Where(x => x.Id != _userManager.GetUserId(User) && x.FollowedBy.Any(followedBy => followedBy.FromArtist == user))
                .Take(10);

            // Adding to view model
            MessagesIndexViewModel viewModel = new MessagesIndexViewModel
            {
                Conversations = conversations.AsEnumerable(),
                Artists = await artists.ToListAsync()
            };

            ViewData["User"] = user;

            return View(viewModel);
        }

        public async Task<IActionResult> Messages(string userName)
        {
            if (!String.IsNullOrEmpty(userName))
            {
                Artist receiver = await _userManager.FindByNameAsync(userName);
                Artist sender = await _userManager.GetUserAsync(User);

                IQueryable<Message> messages =
                    _context.Messages
                    .Where(m => (m.Receiver == receiver && m.Sender == sender) || (m.Receiver == sender && m.Sender == receiver))
                    .OrderBy(m => m.CreationDate);

                MessagesViewModel viewModel = new MessagesViewModel
                {
                    Sender = sender,
                    Receiver = receiver,
                    Messages = messages.ToList()
                };

                return View(viewModel);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage([Bind("SenderId", "ReceiverId", "MessageContent")] MessagesViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Artist sender = await _userManager.FindByIdAsync(viewModel.SenderId);
                Artist receiver = await _userManager.FindByIdAsync(viewModel.ReceiverId);

                Message message = new Message
                {
                    Content = viewModel.MessageContent,
                    CreationDate = DateTime.Now,
                    Sender = sender,
                    Receiver = receiver
                };

                _context.Messages.Add(message);
                await _context.SaveChangesAsync();

                return await GetMessages(viewModel);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetMessages([Bind("SenderId", "ReceiverId")] MessagesViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Artist sender = await _userManager.FindByIdAsync(viewModel.SenderId);
                Artist receiver = await _userManager.FindByIdAsync(viewModel.ReceiverId);

                IQueryable<Message> messages =
                    _context.Messages
                    .Where(m => (m.Receiver == receiver && m.Sender == sender) || (m.Receiver == sender && m.Sender == receiver))
                    .OrderBy(m => m.CreationDate);

                MessagesViewModel nviewModel = new MessagesViewModel
                {
                    Receiver = receiver,
                    Messages = messages.ToList()
                };

                return PartialView("_Messages", nviewModel);
            }
            return NotFound();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConversation(string userName)
        {
            Artist sender = await _userManager.GetUserAsync(User);
            Artist receiver = await _userManager.FindByNameAsync(userName);

            List<Message> messagesToRemove = await
                _context.Messages
                .Where(m => (m.Receiver == receiver && m.Sender == sender) || (m.Receiver == sender && m.Sender == receiver))
                .ToListAsync();

            _context.Messages.RemoveRange(messagesToRemove);
            await _context.SaveChangesAsync();

            return Redirect("/Messages/" + userName);
        }
    }
}