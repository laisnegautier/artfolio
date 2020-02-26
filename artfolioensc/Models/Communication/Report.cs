using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolioensc.Models
{
    public class Report
    {
        public int ReportId { get; set; }

        public string Content { get; set; }

        public Artwork Artwork { get; set; }
        public Artist Artist { get; set; }
    }
}
