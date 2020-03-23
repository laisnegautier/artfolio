using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace artfolio.ValidationAttributes
{
    public class ArtfolioMedia : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            IFormFile file = value as IFormFile;

            string errorImage;
            bool isImage = FormFileExtensions.IsImage(file, out errorImage);
            string errorAudio;
            bool isAudio = FormFileExtensions.IsAudio(file, out errorAudio);
            string errorPdf;
            bool isPdf = FormFileExtensions.IsPDF(file, out errorPdf);

            if (!isImage && !isAudio && !isPdf) return new ValidationResult("The uploaded file must be an image, an audio or a PDF.");
            else if ((!isImage && isAudio && isPdf) || (isImage && isAudio && !isPdf) || (isImage && !isAudio && isPdf)) 
                return new ValidationResult("The uploaded file is corrupted.");

            return ValidationResult.Success;
        }
    }
}
