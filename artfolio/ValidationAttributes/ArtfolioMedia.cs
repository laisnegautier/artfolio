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

            if (FormFileExtensions.IsImage(file)) return ValidationResult.Success;
            return new ValidationResult("The uploaded file needs to be a .png, .jpg or .gif");
        }
    }
}
