
using ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace HRTechProject.Entities
{
    public class Personel : BaseEntity
    {
        public string FotografYolu { get; set; } = null!;

        [Required(ErrorMessage = "Personel adı boş bırakılamaz.")]
        public string Ad { get; set; } = null!;

        public string? Ad2 { get; set; }

        [Required(ErrorMessage = "Personel soyadı boş bırakılamaz.")]
        public string Soyad { get; set; } = null!;

        public string? Soyad2 { get; set; }

        [Required(ErrorMessage = "Doğum tarihi boş bırakılamaz.")]
        public DateTime DogumTarihi { get; set; }

        [Required(ErrorMessage = "T.C. Kimlik numarası boş bırakılamaz.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "T.C. Kimlik numarası 11 haneli olmalıdır.")]
        public string TcNo { get; set; } = null!;

        [Required(ErrorMessage = "İşe giriş tarihi boş bırakılamaz.")]
        public DateTime IseGirisTarihi { get; set; }

        public DateTime? IstenCikisTarihi { get; set; }

        public bool Aktiflik { get; set; }

        public int MeslekId { get; set; }

        public Meslek Meslek { get; set; } = null!;

        [Required(ErrorMessage = "Email boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Geçersiz email adresi.")]
        public string Email { get; set; } = null!;

        public Adres Adres { get; set; } = null!;

        public int AdresId { get; set; }

        [Required(ErrorMessage = "Telefon numarası boş bırakılamaz.")]
        [Phone(ErrorMessage = "Geçersiz telefon numarası.")]
        public string Telefon { get; set; } = null!;

        public decimal Maas { get; set; }
    }
}
