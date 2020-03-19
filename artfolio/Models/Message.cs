using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsRead { get; set; }

        public virtual Artist Sender { get; set; }
        public virtual Artist Receiver { get; set; }
    }
}
