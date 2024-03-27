using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Attributes
{
    public class GecerliResimAttribute : ValidationAttribute
    {
        public double MaxDosyaBoyutuMB { get; set; } = 2;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = (IFormFile?)value;

            if (file == null)
                return ValidationResult.Success;

            if (!file.ContentType.StartsWith("image/"))
            {
                return new ValidationResult("Geçersiz resim dosyası.");
            }
            else if (file.Length > MaxDosyaBoyutuMB * 1024 * 1024)
            {
                return new ValidationResult($"Maximum Dosya Boyutu : {MaxDosyaBoyutuMB} MB");
            }


            return ValidationResult.Success;
        }
    }
}
