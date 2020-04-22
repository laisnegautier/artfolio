using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class Report
    {
        public int ReportId { get; set; }

        public string Content { get; set; }

        public virtual Artwork Artwork { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
