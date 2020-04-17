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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage([Bind("SenderId","ReceiverId","MessageContent")] MessagesIndexViewModel viewModel)
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
        public async Task<IActionResult> GetMessages([Bind("SenderId", "ReceiverId")] MessagesIndexViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Artist sender = await _userManager.FindByIdAsync(viewModel.SenderId);
                Artist receiver = await _userManager.FindByIdAsync(viewModel.ReceiverId);

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
            return NotFound();
        }
    }
}