using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using artfolio.Models;

namespace artfolio.ViewModels
{
    public class MessagesIndexViewModel
    {
        public Artist Sender { get; set; }
        public Artist Receiver { get; set; }
        public IList<Message> Messages { get; set; }

        // Form
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string MessageContent { get; set; }
    }
}
