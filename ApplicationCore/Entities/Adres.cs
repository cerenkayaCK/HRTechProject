using ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace HRTechProject.Entities
{
    public class Adres : BaseEntity
    {
        public List<Personel> Personeller { get; set; } = new();

        [Required(ErrorMessage = "İl alanı boş bırakılamaz.")]
        public string Il { get; set; } = null!;

        [Required(ErrorMessage = "İlçe alanı boş bırakılamaz.")]
        public string Ilce { get; set; } = null!;

        [Required(ErrorMessage = "Mahalle alanı boş bırakılamaz.")]
        public string Mahalle { get; set; } = null!;

        [Required(ErrorMessage = "Sokak alanı boş bırakılamaz.")]
        public string Sokak { get; set; } = null!;

        public int KapiNo { get; set; }

        public int DaireNo { get; set; }

    }
}
