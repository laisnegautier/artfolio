using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace artfolio.Models
{
    public class CreativeCommons
    {
        public int CreativeCommonsId { get; set; }
        public string Title { get; set; }
        public string Acronym { get; set; }
        public string Description { get; set; }
        
        //THIS WILL BE IN THE JOINT TABLE public double Version { get; set; }

        public string LicenseDeedUrl { get; set; }
        public string LegalCodeUrl { get; set; }

        public bool BY { get; set; }
        public bool SA { get; set; }
        public bool ND { get; set; }
        public bool NC { get; set; }
        public bool Zero { get; set; }

        //public virtual List<Artwork> Artworks { get; set; }
    }
}
