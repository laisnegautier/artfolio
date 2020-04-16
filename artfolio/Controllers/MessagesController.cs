using artfolio.Data;
using artfolio.Hubs;
using artfolio.Models;
using artfolio.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
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

        public async Task<IActionResult> Index(string userName)
        {
            if (String.IsNullOrEmpty(userName))
            {
                return NotFound();
            }

            Artist receiver = await _userManager.FindByNameAsync(userName);
            Artist sender = await _userManager.GetUserAsync(User);

            IQueryable<Message> messages =
                _context.Messages
                .Where(m => (m.Receiver == receiver && m.Sender == sender) || (m.Receiver == sender && m.Sender == receiver))
                .OrderBy(m => m.CreationDate);

            MessagesIndexViewModel viewModel = new MessagesIndexViewModel
            {
                Sender = sender,
                Receiver = receiver,
                Messages = messages.ToList()
            };

            return View(viewModel);
        }

        // AJAX
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> MessagesE(string senderId, string receiverId, string messageContent)
        {
            Artist sender = await _userManager.FindByIdAsync(senderId);
            Artist receiver = await _userManager.FindByIdAsync(receiverId);

            if (ModelState.IsValid)
            {
                Message message = new Message
                {
                    Content = messageContent,
                    CreationDate = DateTime.Now,
                    Sender = sender,
                    Receiver = receiver
                };

                _context.Messages.Add(message);
                await _context.SaveChangesAsync();

                //----------------

                IQueryable<Message> messages =
                    _context.Messages
                    .Where(m => (m.Receiver == receiver && m.Sender == sender) || (m.Receiver == sender && m.Sender == receiver))
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