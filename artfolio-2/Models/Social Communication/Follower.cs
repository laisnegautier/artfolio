using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace artfolio.Models
{
    public class Follower
    {
        public int FollowedArtistId { get; set; }
        public Artist FollowedArtist { get; set; }
        public int FollowerArtistId { get; set; }
        public Artist FollowerArtist { get; set; }
    }
}
