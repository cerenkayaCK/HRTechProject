using ApplicationCore.Attributes;
using HRTechProject.Entities;
using Ornek.Attributes;
using System.ComponentModel.DataAnnotations;

namespace HRTechProject.Models
{
    public class PersonelGuncellemeViewModel
    {
        [GecerliResim]
        public IFormFile Fotograf { get; set; } = null!;
        public Adres Adres { get; set; } = null!;

        [Required(ErrorMessage = "Alan boş bırakılamaz!")]
        [Telefon]
        [MaxLength(60)]
        public string Telefon { get; set; } = null!;
    }
}
