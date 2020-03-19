using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace artfolio.Models
{
    public class FollowRelation
    {
        public string FromArtistId { get; set; }
        public virtual Artist FromArtist { get; set; }

        public string ToArtistId { get; set; }
        public virtual Artist ToArtist { get; set; }
    }
}
