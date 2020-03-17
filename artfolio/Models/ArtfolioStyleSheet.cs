using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace artfolio.Models
{
    public class ArtfolioStyleSheet
    {
        public int ArtfolioStyleSheetId { get; set; }

        public string BorderColor { get; set; }
        public byte[] BackgroundCover { get; set; }
        public string TextColor { get; set; }
        public string LinkColor { get; set; }
        public string LinkHoverColor { get; set; }
        public string FontCategory { get; set; }
        public string FontParagraph { get; set; }
        public string FontTitles { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
