using artfolio.Data;
using artfolio.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace artfolio.Hubs
{
    public class MessagesHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Artist> _userManager;

        public MessagesHub(UserManager<Artist> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task SendMessageHub(string senderId, string receiverId)
        {
            // a message is sent from sender to receiver
            await Clients.User(receiverId).SendAsync("ReceiveMessage", senderId, receiverId);
        }
    }
}