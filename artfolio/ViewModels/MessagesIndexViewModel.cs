using artfolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace artfolio.ViewModels
{
    public class MessagesIndexViewModel
    {
        public Artist User { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
    }
}